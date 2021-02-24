using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_24_02_OverloadTestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 가변길이 파라미터(using params)
            // 파라미터의 개수에 상관없이 하나의 메서드로 해결할 수 있는 객체지향 프로그래밍이다.
            
            int total = 0;
            total = Sum(1, 2, 3, 4, 5);
            Console.WriteLine($"합계는 {total} 입니다.");

            Console.WriteLine($"합계는 {Sum(1, 2, 3)}");
            Console.WriteLine($"합계는 {Sum(1, 2, 3, 4, 5)}");

            Console.WriteLine($"10까지의 합은 {Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)}");

            int[] arrs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"10까지의 합은 {Sum(arrs)}");
        }

        
        // 같은 원리인데 개수가 달라서 메서드를 계속 생성해야하는 불편함이 있다.
        // 이때 가변길이 매개변수(params)를 사용하여 해결할 수 있다.

        private static int Sum(params int[] args)
        {
            int result = 0;
            foreach (var arg in args)
            {
                result += arg;
            }
            return result;
        }


        // 이름은 같은데 개수만 달라서 계속 생성한 메서드들(효율이 좋지않음)

        //private static int Sum(int v1, int v2, int v3, int v4, int v5)
        //{
        //    int result = v1 + v2 + v3 + v4 + v5;
        //    return result;
        //}

        //private static int Sum(int v1, int v2, int v3, int v4)
        //{
        //    int result = v1 + v2 + v3 + v4;
        //    return result;
        //}

        //private static int Sum(int v1, int v2, int v3)
        //{
        //    int result = v1 + v2 + v3;
        //    return result;
        //}

        //private static int Sum(int v1, int v2)
        //{
        //    int result = v1 + v2;
        //    return result;
        //}
    }
}
