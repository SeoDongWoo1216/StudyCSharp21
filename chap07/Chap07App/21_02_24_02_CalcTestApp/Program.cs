using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_24_02_CalcTestApp
{
    class Mathz
    {
        // 여러 행위(기능 : 메서드) 들이 많음.
        public int Plus(int a, int b)
        {
            // ...
            return 1;
        }

        //public void PrintEven(int val)   // 짝수면 값을 출력하게 해주는 메서드
        //{
        //    if (val % 2 == 0)
        //    {
        //        Console.WriteLine($"x의 값 : {val}");
        //    }
        //}

        public static void PrintEven(int val)   // 짝수면 값을 출력하게 해주는 메서드
        {
            if (val % 2 == 0)
            {
                Console.WriteLine($"x의 값 : {val}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////

            // 객체, 변수 선언
            //Mathz mathz = new Mathz();
            int x;

            ////////////////////////////////////////////////////////////////////
            
            x = 5;
            //mathz.PrintEven(x);  // 짝수를 골라내는 행위들을  '클래스.메서드'  선언 한줄로 간략화해줄 수 있다.
            Mathz.PrintEven(x);   // 정적필드(static)를 선언했기때문에 바로 호출할 수 있다.
            //if(x % 2 == 0)
            //{
            //    Console.WriteLine($"x의 값 : {x}");
            //}

            ////////////////////////////////////////////////////////////////////

            x = 10;
            //mathz.PrintEven(x);  
            Mathz.PrintEven(x);
            //if(x % 2 == 0)
            //{
            //    Console.WriteLine($"x의 값 : {x}");
            //}
        }
    }
}
