using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap04App
{
    class Program
    {
        static void Main(string[] args)
        {

            // 나머지 연산자 '%' 예제

            var values = 37656234;

            if(values % 2 == 0)
            {
                Console.WriteLine($"{values}는 짝수입니다.");
            }
            else
            {
                Console.WriteLine($"{values}는 아무것도 아닙니다.");
            }

            if (values % 3 == 0)
            {
                Console.WriteLine($"{values}는 3의 배수입니다.");
            }
            else
            {
                Console.WriteLine($"{values}는 3의 배수가 아닙니다..");
            }

            if (values % 7 == 0)
            {
                Console.WriteLine($"{values}는 7의 배수입니다.");
            }
            else
            {
                Console.WriteLine($"{values}는 7의 배수가 아닙니다..");
            }


        }
    }
}
