using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_23_04_RefOutTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a   = 22;
            int b   = 3;
            int val = 0;
            int rem = 0;


            // Divide(a, b, val, rem);         // 메서드부분에서 val, rem 자리는 out 선언을했으므로 메서드 선언에도 out 해줘야한다.
            // Divide(a, b, ref val, ref rem); // out랑 ref나 차이가 없다. 메서드 선언부분과 만드는 부분에 명시해서 똑같이 쓸 수 있다.
            Divide(a, b, out val, out rem);


            Console.WriteLine($"{a} / {b} = {val}");
            Console.WriteLine($"{a} % {b} = {rem}");


            // 문자열 "1000"을 int형으로 변환하여 int형인 result1에 대입하여 저장한다.
            bool isSucceed1 = int.TryParse("1000", out int result1);     
            Console.WriteLine($"변환결과 : {isSucceed1}, result 값 : {result1} 입니다.");


            // 소수는 정수가 아니므로 거짓이 출력되고, 0을 반환한다.
            bool isSucceed2 = int.TryParse("1000.123", out int result2); 
            Console.WriteLine($"변환결과 : {isSucceed2}, result 값 : {result2} 입니다.");
        }


        // out 없으면 값만 가져오는거고, out은 출력 파라미터로써 돌려받을 값을 지정해주면된다.(이는 ref와 동일하다)
        static void Divide(int a, int b, out int quotient, out int remainder)  // 값과 나머지를 모두 return 시키기위해 out 사용
        {
            quotient  = a / b;
            remainder = a % b;
            return;
        }
    }
}
