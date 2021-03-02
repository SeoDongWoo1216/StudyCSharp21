using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_02_02_GenericCopyArrayApp
{
    // 제네릭 타입에 <>를 해주면 어떤 타입이든 올 수 있다.
    // FirstGeneric에서 자료 타입에따라 메서드를 하나씩 만들어줬는데, <T>를 사용하면 타입에 상관없이 메서드 하나로 전부 해결할 수 있다.
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 11, 21, 33, 45, 56 };  // 5개 int 배열
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
        }

        private static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }
}
