using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_23_01_WhileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 반복문
            while (true)
            {
                Console.Write("수를 입력하세요(quit 입력시 종료) : ");
                string line = Console.ReadLine();  // 콘솔에서 입력값을 변수에 저장

                if (line == "quit") break;       // quit 입력시 프로그램 종료

                int number = 0;// 
                // int.Parse(line);              // Parse는 문자열을 정수형으로 바꿔줌.
                int.TryParse(line, out number);  // TryParse는 숫자가아닌 값으로 값이 잘못들어가면 0으로 바꿔줌

                // todo 아래로직을 수정하세요
                if (number > 0)
                {
                    if (number % 2 == 0)
                        Console.WriteLine("0보다 큰 짝수 ");
                    else
                        Console.WriteLine("0보다 큰 홀수 ");
                }

                else if (number < 0)
                {
                    Console.WriteLine("0보다 작은 수 ");
                }

                else
                {
                    Console.WriteLine("숫자를 입력하세요");
                }
                // todo 마지막
            }

            Console.WriteLine("프로그램이 종료되었습니다.");


        }
    }
}
