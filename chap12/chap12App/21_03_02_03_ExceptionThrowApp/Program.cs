using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_02_03_ExceptionThrowApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoSomething(13);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
            }
        }
        private static void DoSomething(int v)
        {
            try
            {
                if (v <= 10)
                {
                    Console.WriteLine($"v*2 = {v * v}");
                }
                else
                {
                    throw new Exception("10보다 큰 값은 계산할 수 없습니다.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"내부 예외 발생 : {ex.Message}");
            }
        }
    }
}
