using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_23_03_LoopTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // do while문
            Console.WriteLine("while문 처리");
            int a = 10;
            while (a > 0)
            {
                Console.WriteLine($"숫자는 {a} 입니다.");
                a -= 2;
            }
            Console.WriteLine("출력 종료");
            Console.WriteLine();

            Console.WriteLine("do~while문 처리");
            a = 10; // do는 무조건 한번은 실행하고 while을 실행 (a가 10이 되었지만 do로인해 한번은 출력됨)
            do  
            {
                Console.WriteLine($"숫자 {a}");
                a++;
            } while (a < 10);
            Console.WriteLine("출력 종료");
            Console.WriteLine();

            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("For문 처리");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i 값은 {i}입니다. ");
            }

            Console.WriteLine();

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"i 값은 {i}입니다. ");
            }
            Console.WriteLine();

            ////////////////////////////////////////////////////////////////////////////////////
            
            Console.WriteLine("구구단 시작");
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i}단 시작");
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
                Console.WriteLine();
            }

        }
    }
}
