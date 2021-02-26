using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_26_01_FirstArrayTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var Varray = new int[5];   // var 타입으로 배열을 선언해도된다.

            ////////////////////////////////////////////////////////////////////////////////////////

            int[] Array2 = { 80, 74, 81, 90, 34 };  // 이렇게 초기화하면 밑의 배열을 초기화하는 5줄을 아낄 수 있다.
            // 이렇게 배열을 선언하고 초기화하는것이 가장 간결한 문구이다.(강사님 피셜)

            ////////////////////////////////////////////////////////////////////////////////////////

            int[] array = new int[5];
            array[0] = 80;
            array[1] = 74;
            array[2] = 81;
            array[3] = 90;
            array[4] = 34;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("콘솔.라이트라인을 이용하여 제일 무식하게 출력");
            Console.WriteLine($"0번째 값 : {array[0]}");
            Console.WriteLine($"1번째 값 : {array[1]}");
            Console.WriteLine($"2번째 값 : {array[2]}");
            Console.WriteLine($"3번째 값 : {array[3]}");
            Console.WriteLine($"4번째 값 : {array[4]}");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();


            // 변하는 값들을 동적으로 출력하는 것이 포인트.
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("for문을 이용해 우아하게 출력");
            for (int i = 0; i < array.Length; i++)  // 스패너는 속성(메서드)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();


            var idx = 0;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("foreach문을 이용해 고급지게 출력");
            foreach (var item in array)
            {
                Console.WriteLine($"{idx++}번째 값 : {item}");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }
    }
}
