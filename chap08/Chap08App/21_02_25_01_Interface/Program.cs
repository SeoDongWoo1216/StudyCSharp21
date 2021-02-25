using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_25_01_Interface
{
    interface ILogger
    {
        void WriteLog(string msg);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"{DateTime.Now} log : {msg}");
        }
    }

    class ClimateLogger
    {
        private ILogger logger;
        public ClimateLogger(ILogger logger)
        {
            this.logger = logger;   // this.멤버변수 = 파라미터
        }

        public void Start()
        {
            while (true)
            {
                Console.Write("온도를 입력하세요 : ");
                string temp = Console.ReadLine();     // 키보드로 값을 입력받음
                if (string.IsNullOrEmpty(temp)) break;

                logger.WriteLog($"현재 온도 : {temp}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ILogger logger = new ILogger();      // 인터페이스는 내용이없기때문에 객체 선언이 되지않는다.
            ILogger logger = new ConsoleLogger();   // 콘솔로그가 I로그를 구현한 구현체니까 선언가능.(자식이 부모클래스로 상속되는거랑 비슷)
            // ConsoleLogger logger = new ConsoleLogger(); 
            logger.WriteLog("로그 출력");    // 직접 제어

            ClimateLogger clogger = new ClimateLogger(new  ConsoleLogger());
            clogger.Start();                 // IoC(제어의 역전(역흐름))

        }
    }
}
