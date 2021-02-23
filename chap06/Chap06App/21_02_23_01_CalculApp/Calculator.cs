using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_23_01_CalculApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            // 메서드 예제

            // 리팩토링 (재공학)
            // 파일명을 Calculator 로 바꾸면서 클래스명을 바꿨지만, Plus는 구현되지 않았다.
            // Plus라는 이름을 가진 메서드를 만들어주어야한다.(이것을 리팩토링이라고 한다)

            int x = Calculator.Plus(3, 4);
            int y = Calculator.Plus(5, 6);
            int z = Calculator.Plus(7, 8);

            int result = x + y + z;
            Console.WriteLine($"Plus 연산의 result는 {result} 입니다.");
        }

        private static int Plus(int v1, int v2)
        {
            // throw new NotImplementedException(); // 메서드를 만들긴 했는데 구현하지않아서 오류가 뜨는 Throw구문.
            // 메서드를 만들었지만 구현하는걸 잊지말라고 일부러 에러를 일으키는 코드를 생성하는 것임.

            Console.WriteLine("Input : {0}, {1}", v1, v2);
            int result = v1 + v2;

            return result;
           
        }
    }
}
