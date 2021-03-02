using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_02_01_ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList를 알아보자.
            ArrayList array2 = new ArrayList(new[] { 80, 74, 81, 90, 34 }); // 이렇게 한줄로 초기화 가능

            ArrayList array = new ArrayList();
            array.Add(80);
            array.Add(74);
            array.Add(81);
            array.Add(90);
            array.Add(34);

            // 인덱스 찾기
            var loc = array.IndexOf(81);
            
            // 배열에 값 삽입
            array.Insert(loc, 50);
            foreach (var item in array)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();

            // 90 지우기
            array.RemoveAt(4);
            foreach (var item in array)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();

            // 배열의 개수 세기
            int iCount = array.Count;
            Console.WriteLine(iCount);
            Console.WriteLine();


            // 배열 정렬
            array.Sort();
            foreach (var item in array)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();

            array.Reverse();
            foreach (var item in array)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();

        }
    }
}
