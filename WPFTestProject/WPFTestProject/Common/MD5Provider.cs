﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WPFTestProject.Common
{
    public class MD5Provider
    {
        public static string GetMD5String(string s)
        {
            MD5 md5 = MD5.Create();
            byte[] pws = md5.ComputeHash(Encoding.UTF8.GetBytes(s));
            string pwd = "";
            foreach(var item in pws)
            {
                pwd += item.ToString("X2");
            }
            return pwd;
        }
    }
}
