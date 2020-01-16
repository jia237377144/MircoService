using Brotli;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace JLP.WebApi.Ef.Core
{
    public class CompressedHttpContent : HttpContent
    {
        private const string GZIP = "gzip";
        private const string DEFLATE = "deflate";
        private const string BR = "br";
        private HttpContent _originalContent;
        private string _encodingType;

        internal CompressedHttpContent(HttpContent content, string encodingType)
        {
            if (content == null)
            {
                throw new ArgumentNullException("content");
            }

            if (encodingType == null)
            {
                throw new ArgumentNullException("encodingType");
            }

            this._originalContent = content;
            this._encodingType = encodingType.ToLowerInvariant();

            //原有代码只判断了GZIP和DEFLATE，因为换了证书之后Accept-Encoding的格式为:br,gzip,deflate
            //所以取到第一个编码的始终为br，就导致抛出异常
            if (this._encodingType != GZIP && this._encodingType != DEFLATE && this._encodingType != BR)
            {
                throw new InvalidOperationException(string.Format("Encoding '{0}' is not supported. Only supports gzip or deflate encoding.", this._encodingType));
            }

            // copy the headers from the original content
            foreach (KeyValuePair<string, IEnumerable<string>> header in this._originalContent.Headers)
            {
                base.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }

            base.Headers.ContentEncoding.Add(encodingType);
        }


        protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            Stream compressedStream = null;

            if (this._encodingType == GZIP)
            {
                compressedStream = new GZipStream(stream, CompressionMode.Compress, leaveOpen: true);
            }
            else if (this._encodingType == DEFLATE)
            {
                compressedStream = new DeflateStream(stream, CompressionMode.Compress, leaveOpen: true);
            }
            else
            {
                compressedStream = new BrotliStream(stream, CompressionMode.Compress, leaveOpen: true);
            }

            return this._originalContent.CopyToAsync(compressedStream).ContinueWith(tsk =>
            {
                if (compressedStream != null)
                {
                    compressedStream.Dispose();
                }
            });
        }

        protected override bool TryComputeLength(out long length)
        {

            length = -1L;
            return false;
        }
    }
}