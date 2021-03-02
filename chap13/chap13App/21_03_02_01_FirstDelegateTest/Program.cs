using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_02_01_FirstDelegateTest
{
    delegate int MyDelegate(int a, int b);  // 대리자.  대신 호출한다. 호출할 메서드와 파라미터 타입/개수가 항상 일치해야함.
    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            var result = calc.Plus(3, 4);
            Console.WriteLine($"result = {result}");          // 기존의 클래스, 메서드 활용

            MyDelegate Callback = new MyDelegate(calc.Plus);
            Console.WriteLine($"\nresult = {Callback(5, 2)}");  // 델리게이트 활용

            Callback = new MyDelegate(calc.Minus);
            Console.WriteLine($"\nresult = {Callback(5, 2)}");
        }
    }
}
