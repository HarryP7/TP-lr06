using System;
using log4net;
using log4net.Config;
using System.Threading;
using MyLibrary;

namespace LR4
{
    class ProgramLog
    {   //объявляем статическую переменную, через которую 
        //работаем логгером и выводим сообщения в лог
        private static readonly ILog log = LogManager.GetLogger("MyLogger");         
            static void Main(string[] args)
        {   //сконфигурируем логгер для работы
            XmlConfigurator.Configure();
            log.Info("Starting application");
            bool f = true;
            do { Console.Write("E - mail: ");
                Password.Login = Console.ReadLine();
                Console.WriteLine(Password.chekLogin(Password.Login));
                if (Password.chekLogin(Password.Login) == "") f = false;
            }while(f);
            do { Console.Write("Введите название вашей компании: ");
                Castomer.plaseWork = Console.ReadLine();
                Console.WriteLine(Castomer.chekPlaseWork(Castomer.plaseWork));
                if (Castomer.chekPlaseWork(Castomer.plaseWork) == "Фирма корректна")
                    f = true;
            }while(!f);
            Thread tA = new Thread(GoA);
            log.Info("Invoking thread A.");
            tA.Start();
            Thread tB = new Thread(GoB);
            tB.Start();
            
            log.Info("Finishing application...");
            Console.WriteLine("Done...");
            Console.ReadKey();
        }
        public static void GoA()
        {
            double i, j;
            Console.WriteLine("Divide and Rule");
            if(true)
            {   log.Warn("Do somthing");
                Console.Write("Введите i = ");
                i = double.Parse(Console.ReadLine());
                Console.Write("Введите j = ");
                j = double.Parse(Console.ReadLine());
                String res = Class1.SumFunc(i, j);
                Console.WriteLine(res);
                Console.ReadLine();
            }
        }
        public static void GoB()
        {
            if (true)
                log.Error("Little Error..."); 
            Console.WriteLine("Bye!");
        }
    }
}
