using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_02_01_FirstGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 11, 21, 33, 45, 56};  // 5개 int 배열
            int[] target = new int[source.Length];

            CopyArray(source, target);
            Console.WriteLine("int 배열복사");
            foreach (var item in target)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            string[] source2 = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] target2 = new string[source2.Length];

            CopyArray(source2, target2);
            Console.WriteLine("string 배열 복사");
            foreach (var item in target2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            float[] source3 = { 1.1f, 2.2f, 3.3f, 4.5f, 6.6f };
            float[] target3 = new float[source3.Length];

            CopyArray(source3, target3);
            Console.WriteLine("float 배열 복사");
            foreach (var item in target3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private static void CopyArray(float[] source, float[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        private static void CopyArray(string[] source, string[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        private static void CopyArray(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }
}
