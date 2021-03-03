using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_03_01_stringApp
{
    class Program
    {
        string Temp2 = "Global Varibal String";   // var 불가, 글로벌 변수
        static void Main(string[] args)
        {
            Console.WriteLine("★문자열 연습 시작★");
            Console.WriteLine("-------------------------------------------------------------");
            //////////////////////////////////////////////////////////////////////////////////

            // 기본 선언
            Console.WriteLine("문자열은 초기화를해줘야 사용할 수 있다.(null로 초기화)");
            string message1 = null;
            Console.WriteLine($"{message1}");
            Console.WriteLine("-------------------------------------------------------------");


            // 빈 값으로 초기화
            Console.WriteLine("빈 값으로 초기화");
            string message2 = "";
            string message22 = System.String.Empty;
            Console.WriteLine($"\"{message2}\", \"{message22}\" ");
            Console.WriteLine("-------------------------------------------------------------");


            // 폴더, 파일 경로
            string oldPath = "C:\\Program Files\\Bandizip";  // 오래된 버전 : 역슬래시는 출력하려면 2번 입력해줘야함.
            string newPath = @"C:\Program Files\Bandizip";   // 새로운 버전 : @만 붙이면 경로 그대로 사용가능.


            // 대문자 String으로 선언해도 차이가 없다.
            Console.WriteLine("대문자 String 선언");
            String greeting = "Hello World!";
            Console.WriteLine($"{greeting}");
            Console.WriteLine("-------------------------------------------------------------");


            // var는 메인 함수나, 지역 변수에만 사용가능
            var temp1 = "Local Variable String";


            // 문자 배열이(char[]) 문자열이다(string)
            Console.WriteLine("char[]이 string이다");
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string hello = new string(letters);
            Console.WriteLine(hello);
            Console.WriteLine("-------------------------------------------------------------");


            // 문자열 결합(문자열 + 문자열)
            Console.WriteLine("문자열 + 문자열 (1)");
            string s1 = "Hello ";
            string s2 = "World!";
            s1 += s2;
            Console.WriteLine($"{s1}");
            Console.WriteLine("-------------------------------------------------------------");


            // 문자열 결합2(문자열 + 문자열)
            Console.WriteLine("문자열 + 문자열 (2)");
            string s3 = "Hello";
            string s4 = s3;
            s3 += "World";
            Console.WriteLine($"{s3}");
            Console.WriteLine("-------------------------------------------------------------");


            // 이스케이프 시퀀스
            Console.WriteLine("이스케이프 시퀀스(\\r \\n) 사용");
            string row = "Row1\r\nRow2\r\nRow3";  // 표준 유형
            Console.WriteLine(row);
            Console.WriteLine("-------------------------------------------------------------");

            string row2 = "Row11\nRow22\nRow33";  // 가장 짧은 유형
            Console.WriteLine(row);
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("Row11" + Environment.NewLine + "Row222" + Environment.NewLine + "Row333");
            Console.WriteLine("-------------------------------------------------------------");


            // 문자열은 저장한 그대로(엔터를 누른것도 그대로) 출력된다.
            Console.WriteLine("문자열은 저장한 그대로(엔터를 누른것도 그대로) 출력된다.");
            string oldline = "Test" + "Test2" + "Test3";
            string multiline = @"New Test 
                                These are multiline 
                                end.";  
            Console.WriteLine();
            Console.WriteLine(oldline);
            Console.WriteLine();
            Console.WriteLine(multiline);
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");


            // 유니코드 이스케이프 시퀀스
            Console.WriteLine("\U0001F47D");
            Console.WriteLine("-------------------------------------------------------------");


            // 문자열 출력
            Console.WriteLine("여러가지 문자열 출력");
            var book = (lastName: "박", firstName: "상현", title: "이것이 C#이다", company: "한빛미디어", 
                releaseDate: "2018-07-01", price: 30000, page: 812
                );
            Console.WriteLine($"{book.lastName}{book.firstName} 저자의 {book.title} ({book.company})");
            Console.Write    ($"{DateTime.Parse(book.releaseDate).ToString("yyyy년 MM월 dd일")} 출간, ");
            Console.WriteLine($"페이지수:{book.page}, 금액:{book.price:#,###}원");

            Console.WriteLine("-------------------------------------------------------------");


            // 문자열 조작(함수사용)
            Console.WriteLine("공백 없애기          ( string.trim() )");
            string s5 = " Visual C# Express ";        // 총 19자리
            Console.WriteLine(s5.Trim());
            Console.WriteLine("-------------------------------------------------------------");

            var s6 = s5.Trim();                       // 총 17자리 "Visual C# Express"
            Console.WriteLine("문자열 자르기        ( string.Substring() ), 오버라이딩되어있어서 2개 메서드 사용가능");
            Console.WriteLine(s6.Substring(7));       // 첫번째부터 7번째글자자르고 나머지 문자열 출력
            Console.WriteLine(s6.Substring(7,2));     // 7번째부터 2글자만 추출
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("문자열 삽입          ( string.Replace()로 C#을 Basic으로 바꿈)");
            Console.WriteLine(s6.Replace("C#", "Basic"));
            Console.WriteLine(s6.Replace(s6.Substring(7, 2), "Basic"));   // 동적 프로그래밍
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("문자열 index 추출    ( string.IndexOf() )");
            Console.WriteLine(s6.IndexOf("C"));
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("문자열 길이 추출     ( string.Length() )");
            Console.WriteLine(s6.Length);  // 문자열 길이인 17 출력
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("문자열 대문자로 출력 ( string.ToUpper() )");
            Console.WriteLine(s6.ToUpper());
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("문자열 소문자로 출력 ( string.ToLower() )");
            Console.WriteLine(s6.ToLower());
            Console.WriteLine("-------------------------------------------------------------");


            // null 문자열 빈문자열
            Console.WriteLine("null/빈문자열 처리");

            string str = "hello";
            string nullstr = null;
            string emptystr = string.Empty;

            Console.WriteLine(str + nullstr);        // hello 출력
            Console.WriteLine(nullstr == emptystr);  // null과 empty로 비어있는 값은 다른 것임.
            Console.WriteLine("-------------------------------------------------------------");

            try
            {
                Console.WriteLine(nullstr.Equals(emptystr)); // null은 Equals가 성립하지 않는다. => 예외발생
                Console.WriteLine(emptystr.Length);
                Console.WriteLine(nullstr.Length);  // null은 길이가 없기때문에 오류가 뜬다.     => 예외발생
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
            }

            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}
