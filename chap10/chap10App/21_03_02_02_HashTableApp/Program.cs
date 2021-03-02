using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_02_02_HashTableApp
{
    class Program
    {
        // Hashtable 예제
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["일"] = "One";
            ht["이"] = "Two";
            ht["삼"] = "Three";
            ht["사"] = "Four";

            Console.WriteLine(ht["일"]); // One   출력
            Console.WriteLine(ht["이"]); // Two   출력
            Console.WriteLine(ht["삼"]); // Three 출력
            Console.WriteLine(ht["사"]); // Fout  출력
            Console.WriteLine();

            // 해쉬테이블 출력
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
                // 데이터가 들어간 순서없이 무작위로 출력됨.
                // 해쉬테이블은 정렬이 되지 않음.
            }

        }
    }
}
