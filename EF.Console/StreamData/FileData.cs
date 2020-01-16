using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.StreamData
{
    public class FileData
    {

        private static string _dictPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log");
        private const string FILE_WRITE_NAME = "testwrite.log";
        private const string FILE_READ_NAME = "testread.log";

        public static void Run()
        {
            CreateDict();
            //CreateWriteFile(DateTime.Now.ToString("yyyy/MM/dd HH:mm:dd.fff"));
            ReadFile();
            //GetAllDict(@"D:\","","dict.txt");

        }

        public static void CreateDict()
        {

            if (!Directory.Exists(_dictPath))
            {
                Directory.CreateDirectory(_dictPath);
                System.Console.WriteLine($"{_dictPath} 文件夹不存在，新创建！");
            }
            else
            {
                System.Console.WriteLine($"{_dictPath} 文件夹已存在！");
            }

        }

        public static void ReadFile()
        {
            string filePath = Path.Combine(_dictPath, FILE_READ_NAME);
            if (File.Exists(filePath))
            {
                StringBuilder contentBuilder = new StringBuilder(1024);
                using (FileStream fileStream = File.OpenRead(filePath))
                {

                    byte[] buffer = new byte[1024];
                    fileStream.Seek(0, SeekOrigin.Begin);//可以设置第一个参数
                    while (true)
                    {
                        buffer.Initialize();
                        int readCount = fileStream.Read(buffer, 0, buffer.Length);
                        contentBuilder.Append(Encoding.UTF8.GetString(buffer));
                        //既然是死循环 那么什么时候我们停止读取文本内容 我们知道文本最后一行的大小肯定是小于缓存内存大小的
                        if (readCount < buffer.Length)
                        {
                            break; //结束循环
                        }
                        Array.Clear(buffer, 0, buffer.Length);
                    }
                }

                using (FileStream fileStream = File.OpenRead(filePath))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        //contentBuilder.Append(streamReader.ReadToEnd());
                        string s = string.Empty;
                        while ((s = streamReader.ReadLine()) != null)
                        {
                            contentBuilder.Append(s);
                        }
                    }
                }
                CreateWriteFile(contentBuilder.ToString());
            }
            else
            {
                System.Console.WriteLine($"{filePath} 文件不存在！");
            }
        }

        public static void CreateWriteFile(string content)
        {
            string filePath = Path.Combine(_dictPath, FILE_WRITE_NAME);
            if (!File.Exists(filePath))
            {
                System.Console.WriteLine($"{filePath} 文件不存在，新创建！");
            }
            else
            {
                System.Console.WriteLine($"{filePath} 文件已存在！");
            }
            WritToFile(content);

        }

        static void WritToFile(string content)
        {
            string filePath = Path.Combine(_dictPath, FILE_WRITE_NAME);
            using (var fileStream = File.OpenWrite(filePath))
            {
                using(var streamWrite=new StreamWriter(fileStream))
                {
                    //string dateString = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
                    var bytes = Encoding.UTF8.GetBytes(content);
                    fileStream.Write(bytes, 0, bytes.Length);
                    fileStream.Flush();

                    streamWrite.Write(content);
                    streamWrite.Flush();
                }
                
            }
        }



        /// <summary>
        /// 把给定目录的树状结构输出到文件
        /// </summary>
        /// <param name="rootDict"></param>
        /// <param name="split"></param>
        /// <param name="outputPath"></param>
        public static void GetAllDict(string rootDict, string split, string outputPath)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), outputPath);
            //将输出流定向到文件 outputpath
            StringWriter swOutput = new StringWriter();
            System.Console.SetOut(swOutput);
            GetAllDict(rootDict, "");

            //将输出流输出到文件 outputpath
            File.WriteAllText(outputPath, swOutput.ToString());

            //将输出流重新定位回文件 outputpath
            StreamWriter swConsole = new StreamWriter(
            System.Console.OpenStandardOutput(), System.Console.OutputEncoding);
            swConsole.AutoFlush = true;
            System.Console.SetOut(swConsole);
            System.Console.WriteLine("Finish!");

        }


        /// <summary>
        /// 输出给定目录的树状结构
        /// </summary>
        /// <param name="rootDict"></param>
        /// <param name="split"></param>
        public static void GetAllDict(string rootDict, string split)
        {
            if (!Directory.Exists(rootDict))
            {
                System.Console.WriteLine("路径不存在！");
            }
            System.Console.WriteLine($"{split} - {rootDict}");
            split += " | ";
            string[] pathDicts = Directory.GetDirectories(rootDict);
            string[] childDicts;
            foreach (string path in pathDicts)
            {
                System.Console.WriteLine($"{split} - {path}");
                try
                {
                    childDicts = Directory.GetDirectories(path);

                    if (childDicts != null && childDicts.Length > 0)
                    {
                        foreach (string childDict in childDicts)
                        {

                            System.Console.WriteLine($"{split} - {childDict}");
                            GetAllDict(childDict, split);
                        }
                    }
                }
                catch (System.UnauthorizedAccessException ex)
                {
                    System.Console.WriteLine($"{path} 无权限访问！");
                }
            }

        }

    }
}
