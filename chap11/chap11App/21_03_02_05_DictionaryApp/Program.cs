using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_02_05_DictionaryApp
{
    class Program
    {
        // 실무에서 많이 쓰는 컬렉션 2
        static void Main(string[] args)
        {
            // 초기화방법은 2가지!
            Dictionary<int, string> pairs5 = new Dictionary<int, string>()
            {
                {1, "One" },
                {2, "Two" },
                {3, "Three" },
                {4, "Four" },
                {5, "Five"}
            };


            Dictionary<int, string> pairs = new Dictionary<int, string>();
            pairs[1] = "One";
            pairs[2] = "Two";
            pairs[3] = "Three";
            pairs[4] = "Four";
            pairs[5] = "Five";

            // Key, Value를 따로 출력할 수도 있음.
            foreach (var item in pairs)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            Console.WriteLine();


            // 문자열로 바꿔보자.
            Dictionary<string, string> pairs2 = new Dictionary<string, string>();
            pairs2["일"] = "One";
            pairs2["이"] = "Two";
            pairs2["삼"] = "Three";
            pairs2["사"] = "Four";
            pairs2["오"] = "Five";

            // 해쉬테이블과는 다르게 넣은 순서대로 나옴(해쉬테이블은 무작위로 출력됨)
            foreach (var item in pairs2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
