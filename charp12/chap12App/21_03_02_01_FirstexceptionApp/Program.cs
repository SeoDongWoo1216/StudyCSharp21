using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_02_01_FirstexceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            // for (int i = 0; i < 5; i++)      
            // 5번 돌리고 싶지만 배열의 길이가 그만큼 안되므로 예외가 발생하여 프로그램이 팅김.

            for (int i = 0; i< arr.Length; i++)
            {
                Console.WriteLine($"{i} 번째 값 : {arr[i]}");
            }
        }
    }
}
