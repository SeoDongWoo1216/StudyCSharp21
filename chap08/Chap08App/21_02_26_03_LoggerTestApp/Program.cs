using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_26_03_LoggerTestApp
{
    // 인터페이스를 클래스에쓰면 구현
    // 인터페이스 상속을 구현 이라고 부름.

    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] arg);
    }

    class ConsoleFormatLogger : IFormattableLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            string message = String.Format(format, args); 
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConsoleLogger 테스트");
            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("로그 메세지");

            IFormattableLogger logger2 = new ConsoleFormatLogger();
            logger2.WriteLog("{0} * {1} = {2}", 3, 4, 12);
        }
    }
}
