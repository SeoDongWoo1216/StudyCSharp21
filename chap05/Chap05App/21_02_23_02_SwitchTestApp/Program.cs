using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_23_02_SwitchTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 스위치문
            while (true)
            {
                Console.Write("요일을 입력하세요(quit 입력시 종료) : ");
                string day = Console.ReadLine();  // 콘솔에서 입력값을 변수에 저장

                if (day == "quit") break;

                //if(day == "월요일")
                //{
                //    Console.WriteLine("월요일입니다");
                //}
                //else if (day == "화요일")
                //{
                //    Console.WriteLine("화요일입니다");
                //}
                //else if (day == "수요일")
                //{
                //    Console.WriteLine("수요일입니다");
                //}
                //else if (day == "목요일")
                //{
                //    Console.WriteLine("목요일입니다");
                //}
                //else if (day == "금요일")
                //{
                //    Console.WriteLine("금요일입니다");
                //}
                //else if (day == "토요일")
                //{
                //    Console.WriteLine("토요일입니다");
                //}
                //else if (day == "일요일")
                //{
                //    Console.WriteLine("일요일입니다");
                //}
                //else
                //{
                //    Console.WriteLine("요일이 아닙니다.");
                //}


                // 위의 긴 if, else if 문을 switch문으로 표현할 수 있다.
                switch (day)
                {
                    case "월요일":
                        Console.WriteLine("월요일입니다.");
                        break;
                    case "화요일":
                        Console.WriteLine("화요일입니다.");
                        break;
                    case "수요일":
                        Console.WriteLine("수요일입니다.");
                        break;
                    case "목요일":
                        Console.WriteLine("목요일입니다.");
                        break;
                    case "금요일":
                        Console.WriteLine("금요일입니다.");
                        break;
                    case "토요일":
                        Console.WriteLine("토요일입니다.");
                        break;
                    case "일요일":
                        Console.WriteLine("일요일입니다.");
                        break;
                    default:
                        Console.WriteLine("요일이 아닙니다.");
                        break;
                }
            }
            Console.WriteLine("프로그램이 종료되었습니다.");
        }
    }
}
