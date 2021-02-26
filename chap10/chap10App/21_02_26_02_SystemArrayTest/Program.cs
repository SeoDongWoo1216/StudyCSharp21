using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_26_02_SystemArrayTest
{
    // 배열.( )     배열 에는 많은 메서드가있다. 그것을 알아보자.
    class Test
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            // test.( )        클래스에도 메서드가 존재한다. 

            int[] array = { 80, 74, 81, 90, 34 };
            Console.WriteLine($"Type of array      : {array.GetType()}");  // GetType을 이용해 어떤 데이터 타입인지 출력
            Console.WriteLine($"Base Type of array : {array.GetType().BaseType}");  // 어떤 배열 클래스를 가져왔는지 보는 출력문
            Console.WriteLine("----------------------------------------------------");


            // 배열 오름차순 정렬
            Array.Sort(array);              
            Console.WriteLine("오름차순 정렬(Sort)");
            for (int i = 0; i < array.Length; i++)  
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
            Console.WriteLine("----------------------------------------------------");


            // 배열 내림차순 정렬
            Array.Reverse(array);
            Console.WriteLine("내림차순 정렬(Sort)");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
            Console.WriteLine("----------------------------------------------------");


            // 배열 IndexOf(몇번째에 있는 값인지)
            Console.WriteLine("배열 IndexOf(몇번째에 있는 값인지)");
            int idx1 = Array.IndexOf(array, 34);    // 34가 몇번째에 있는지 정수형 값으로 반환
            int idx2 = Array.IndexOf(array, 100);   // 배열에 없는 값을 대입하면 -1을 반환한다.
            Console.WriteLine($"34의 인덱스  : {idx1}");
            Console.WriteLine($"100의 인덱스 : {idx2}");
            Console.WriteLine("----------------------------------------------------");


            // 배열 삭제
            Console.WriteLine("배열 삭제(2번째부터 2개를 0)");
            Array.Clear(array, 2, 2);              // array 배열의 2번째부터 2개를 삭제(2번째, 3번째의 값이 0이 된다.)
         // Array.Clear(배열이름, 인덱스, 길이) => '배열이름'의 '인덱스'만큼의 '길이'만큼 배열값을 삭제
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
            Console.WriteLine("----------------------------------------------------");


            // 배열 크기 조정
            Console.WriteLine("배열 크기 조절");
            Array.Resize(ref array, 6);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
            Console.WriteLine("----------------------------------------------------");


            // 배열 크기를 늘린 후, 값 삽입 : 배열의 단점을 보여주는 예시
            Console.WriteLine("배열 크기를 늘린 후, 값 삽입");
            int idx = Array.IndexOf(array, 81);
            for (int i = array.Length - 1; i >= idx; i--)
            {
                array[i] = array[i - 1];
            }
            Console.WriteLine("----------------------------------------------------");
            array[idx] = 50;
            for (int i = array.Length - 1; i >= idx; i--)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
            Console.WriteLine("----------------------------------------------------");


            // 값을 새로 넣으려면 배열을 늘리고 값들을 한칸씩 땡긴다음에 값을 삽입해야한다.
            // 이짓이 귀찮은 일이기때문에 컬렉션을 사용한다.

        }
    }
}
