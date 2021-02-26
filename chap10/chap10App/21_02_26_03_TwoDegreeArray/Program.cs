using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_26_03_TwoDegreeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };  // 선언과 동시에 초기화(밑의 초기화 6줄을 절약할 수 있다)
            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };                // 더 간결한 초기화방법.

            int[,] arr = new int[2, 3];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;
            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;

            foreach (var item in arr)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();

            for (int i = 0; i < arr.GetLength(0); i++)      // GetLength(0)를 통해 행의 값을 가져온다.
            {
                for (int j = 0; j < arr.GetLength(1); j++)  //  GetLength(1)를 통해 열의 값을 가져온다.
                {
                    Console.Write($"[{i},{j}] : { arr[i,j] }\t");
                }
                Console.WriteLine();
            }
        }
    }
}
