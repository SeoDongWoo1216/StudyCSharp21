using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_23_03_SortingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // call by vaule
            // call by reference 예제
            // 콜바이벨류를 주석처리했음.

            int x = 47, y = 5;
            Console.WriteLine($"before Swap {x}, {y}");


            // 정렬 메서드
            // Program.Swap(x, y);       // 값을 복사하지만 자체 값은 변하지않기때문에 출력해도 값의 변화는 없다.
            Program.Swap(ref x, ref y);  // ref를 붙여주는것으로 주소값을 복사한다. 따라서 값이 바뀐것을 확인할 수 있다.


            Console.WriteLine($"After Swap {x}, {y}");
        }

        // call by value
        //private static void Swap(int p1, int p2)
        //{
        //    int temp = p1;
        //    p1 = p2;
        //    p2 = temp;
        //}


        // call by reference = call by address
        private static void Swap(ref int p1, ref int p2)
        {
            int temp = p1;
            p1 = p2;
            p2 = temp;
        }
    }
}
