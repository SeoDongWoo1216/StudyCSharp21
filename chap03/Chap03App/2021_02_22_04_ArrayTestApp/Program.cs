using System;

namespace _2021_02_22_04_ArrayTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("배열테스트");

            int[] iarr = new int[10];

            for(var i = 0; i < iarr.Length; i++)
            {
                iarr[i] = i + 1;
            }

            for (int i = 0; i < iarr.Length; i++)
            {
                Console.WriteLine($"iarr[{i}]의 값은 {iarr[i]}입니다.");
                //Console.WriteLine($"iarr[{0}]의 값은 {1}입니다.", i, iarr[i]);
            }
        }
    }
}
