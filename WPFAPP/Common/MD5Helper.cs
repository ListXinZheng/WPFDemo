using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WPFAPP.Common
{
    public class MD5Helper
    {
        /// <summary>
        /// MD5处理
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetMD5string(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] buffer = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            string pwd = string.Empty;
            foreach (byte b in buffer)
            {
                pwd += b.ToString("X2");
            }
            return pwd;
        }
    }
}
