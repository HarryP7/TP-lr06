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
            List<string> List = new List<string> { "Kontinenent@gmail.com", "Lucoil@gmail.com", "Megafon@gmail.com", "Tehnostroy@gmail.com" };
            if (Login.Length < 4 &&
                Regex.IsMatch(Login, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                return "Введите корректный E-mail, более 4х символов.";
            return "";
        }
		public method1(){
			//Do somthing
		}
    }
    class Castomer
    {
        public static String plaseWork;

        public static String chekPlaseWork(String plaseWork)
        {
            List<string> List = new List<string> {"OOO Континент", "ПАО Лукойл", "ПАО МегаФон", "ООО Трансстрой" };
            for (int j = 0; j < List.Count; j++)
            {
                if (plaseWork == List[j])
                {
                    return "Фирма корректна";
                }
            }
            return "Фирма не существует\nПовтотрите ввод";
        }
    }
	
}
