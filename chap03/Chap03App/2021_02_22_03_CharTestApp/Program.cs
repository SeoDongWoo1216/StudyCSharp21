using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_02_22_03_CharTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자
            Console.WriteLine("-----------------------------문자------------------------------");
            // char ch9 = 'test' 은 오류인데, ''는 문자 1개만 저장할 수 있기때문. (글자를 여러개쓰면 '문자열'(string)이 된다.)
            char ch1 = 't',   // 일반적인 글자
                 ch2 = '\t',   // Tab 효과
                 ch3 = '\n',   // 엔터효과
                 ch4 = '0';    // 숫자 0 저장
            Console.WriteLine($"{ch1}, {ch2}, {ch3}, {ch4}");

            char ch5 = '\\'; // 역슬래시 출력하려면 2개를 입력해야함.
            Console.WriteLine($"{ch5}");
            Console.WriteLine();

            // char ch9 = 'test' 은 오류인데, ''는 문자 1개만 저장할 수 있기때문. (글자를 여러개쓰면 '문자열'(string)이 된다.)


            // 문자열
            Console.WriteLine("-----------------------------문자열-----------------------------");
            string str1 = "Hello, World!";
            // Console.WriteLine(str1);
            Console.WriteLine($"{str1}");

            string str2 = "\tHello, \nWorld!";  // 이스케이프 시퀀스 사용
            Console.WriteLine($"{str2}");
            Console.WriteLine();


            // 불린형
            Console.WriteLine("-----------------------------불린형-----------------------------");
            bool isCorrect = false;
            Console.WriteLine(isCorrect);
            if (isCorrect)
            {
                Console.WriteLine("참입니다.");
            }
            else
            {
                Console.WriteLine("거짓입니다.");
            }
        }
    }
}
