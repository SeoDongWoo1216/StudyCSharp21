using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_02_22_06_ConstTestApp
{
    class Program
    {
        enum Season
        {
            Spring,  // Spring부터 0부터 정수가 매핑된다.
            Summer,
            Fall,
            Winter,

            봄,
            여름,
            가을,
            겨울,

            따로지정여름 = 1000
        }
        static void Main(string[] args)
        {
            // const 예제

            Console.WriteLine("상수테스트");
            const double PI = 3.141592;
            Console.WriteLine($"원주율의 값은 {PI}");
            // PI = 6.345;  // 상수인 const를 선언했으므로 PI 값은 바뀌지않는다.
            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////////////////

            // enum(열거형) 예제
            Season mySeason1 = Season.Summer;
            Season mySeason2 = Season.여름;
            Season mySeason3 = (Season) 1;
            Season mySeason4 = (Season) 1000;
            Console.WriteLine($"지금 계절은 {mySeason1} 입니다.");
            Console.WriteLine($"지금 계절은 {mySeason2} 입니다.");
            Console.WriteLine($"지금 계절은 {mySeason3} 입니다.");
            Console.WriteLine($"지금 계절은 {mySeason4} 입니다.");
            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////////////////

            int a = 0;
            // int a = null;  // 기존 형식에서는 null을 넣을 수 없음
            Console.WriteLine($"a는 {a}");

            int? b = null;    // 데이터형의 '?' 를 표기하면 null을 대입할 수 있음.
            Console.WriteLine($"b는 [{b}]");  // null은 표현할 수 없으므로 출력해도 아무것도 나오지 않음.( '[]'로 표시)


        }
    }
}
