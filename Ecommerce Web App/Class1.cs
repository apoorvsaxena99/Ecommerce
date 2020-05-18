using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_Web_App
{
    public class Class1
    {
        public static string GetRandomPassword(int length) { 
        char[] chars="0123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ".ToCharArray();
        string password = string.Empty;
        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            int x = random.Next(1, chars.Length);
            if (!password.Contains(chars.GetValue(x).ToString()))
                password += chars.GetValue(x);
            else
                i = i - 1;
        }
        return password;
        
        
        
        }
    }
}