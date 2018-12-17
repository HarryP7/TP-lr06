using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LR4
{
    static class Password
    {
        public static string Login;
        public static string Pass;
        public static String chekLogin(String Login)
        {
            
        }
    }
    class Castomer
    {
        public static String plaseWork;
        public static String chekPlaseWork(String plaseWork){
            List<string> List = new List<string> {"OOO Континент", "ПАО Лукойл", "ПАО МегаФон", "ООО " };
            for (int j = 0; j < List.Count; j++)
            {
                if (plaseWork == List[j])
                {
                    return "";
                }
            }
            return "";
        }
    }
}
