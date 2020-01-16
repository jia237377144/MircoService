using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommLib
{

    public static class DateTimeExtensions
    {
        public static string ToString_yyyyMMdd(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd");
        }
        public static string ToString_yyyyMMddHH(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH");
        }

        public static string ToString_yyyyMMddHHmm(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH mm");
        }

    }
}
