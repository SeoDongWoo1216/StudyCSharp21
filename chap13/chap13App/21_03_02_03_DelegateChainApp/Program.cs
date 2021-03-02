using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_02_03_DelegateChainApp
{
    delegate void AllCalc(int x, int y); // 대리자 선언

    class Program
    {
        static void Plus(int a, int b)     { Console.WriteLine($"a + b = {a + b}"); }
        static void Minus(int a, int b)    { Console.WriteLine($"a - b = {a - b}"); }
        static void Multiple(int a, int b) { Console.WriteLine($"a * b = {a * b}"); }
        static void Divide(int a, int b)   { Console.WriteLine($"a / b = {a / b}"); }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating!!");  
            AllCalc allCalc = Plus;  // 델리게이트 이용
            // AllCalc allCalc2 = new AllCalc(Plus);   // 초기화는 이렇게 작성해도 같다.
            allCalc += Minus;
            allCalc += Multiple;
            allCalc += Divide;

            allCalc(10, 5);     // 모든 계산이 한줄로 처리됨.
            Console.WriteLine();

            Console.WriteLine("곱셈 메서드 제거");
            // 곱셈을 빼고싶다!고 하면 빼주면됨.
            allCalc -= Multiple;
            allCalc(10, 5);

            // 이렇게 += 와 -= 코드는 윈폼에도 나오니까 참고하는 것이 좋을것 같음.

            /*
            Plus(10, 5);     // 기존의 메서드 이용
            Minus(10, 5);
            Multiple(10, 5);
            Divide(10, 5);
            Console.WriteLine();
            */
        }
    }
}
