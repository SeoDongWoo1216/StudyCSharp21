using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_23_07_JumpTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 점프문 예제

            // continue
            Console.WriteLine("continue사용");
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                    continue;  // 지금 반복문에서 한 단계 건너뜀
                Console.WriteLine(i);
            }
            Console.WriteLine();


            // break
            Console.WriteLine("break사용");
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                    break;     // 지금 반복문을 종료
                Console.WriteLine(i);
            }
        }
    }
}
