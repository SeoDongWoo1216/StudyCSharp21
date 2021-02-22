using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncDecTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("증감연산자 테스트");

            int result = 26;
            Console.WriteLine($"현재 숫자는 {result} 입니다.");

            result += 3;
            Console.WriteLine($"현재 숫자는 {result} 입니다.");

            result -= 10;
            Console.WriteLine($"현재 숫자는 {result} 입니다.");
            Console.WriteLine();

            Console.WriteLine($"후치증감 값은 {result++} 입니다."); // 후치연산 : 이 줄을 실행하고, 연산자를 연산함.(출력은 19, 값은 20으로 저장)
            Console.WriteLine($"전치증감 값은 {++result} 입니다."); // 1증가시킨 후에 출력 

        }
    }
}
