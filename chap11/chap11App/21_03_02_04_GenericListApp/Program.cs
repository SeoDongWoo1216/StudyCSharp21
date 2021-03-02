using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_02_04_GenericListApp
{
    class Program
    {

        // 실무에서 가장 많이 사용되는 컬렉션1
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("list 배열 출력");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Descending(역정렬)");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("----------------------------------------------");

            list.Insert(3, 20);
            Console.WriteLine("값 추가(Insert)");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("----------------------------------------------");

            list.RemoveAt(5);
            Console.WriteLine("5번째값 제거(RemoveAt)");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("----------------------------------------------");


            List<string> strList = new List<string>() { "일", "이", "삼", "사", "오" };
            Console.WriteLine("문자열 리스트");
            foreach (var item in strList)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}
