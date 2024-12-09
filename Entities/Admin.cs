using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Students.Tools;

namespace Students.Entities
{
    public static class Admin
    {
        private static string? _userName { get; set; } = "admin";
        private static string? _password { get; set; } = "1234";
        public static void ChangePassWord(string password)
        {
            _password = password;
        }
        public static bool Login(string username, string password)
        {
            if (username.ToLower() == _userName?.ToLower() && password == _password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}