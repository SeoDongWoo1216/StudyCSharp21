using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_23_02_ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("홍길동", "01012345678");
           // PrintProfile(null, "010-1111-2222");  // null은 값이 아닌 값으로 화면에 출력되지 않음(공간도없음)

            if(PrintProfile(null, "010-1111-2222") == -1)
            {
                Console.WriteLine("프로필 출력시 오류가 발생했습니다.");
            }

            // 명명된 매개 변수
            PrintProfile(phone: "010-9999-8888", name: "홍길동");
            PrintProfile(name: "홍길순", phone: "010-1111-2222");  // 매개변수의 순서가 달라도 상관없다.


            // 선택적 매개 변수
            PrintProfile("최백호");                   // phone을 입력안했어도 메서드에 기본값이있으므로 오류가 뜨지않는다.
            PrintProfile("최백호", "010-7894-6543");  // 새로운 매개변수가 추가되면 추가된 매개변수를 출력한다.
            // PrintProfile("010-7894-6543");         // 메서드에 기본값이 없으므로 오류(컴파일러가 name인지 phone인지 구분 불가)
            
            
            // 따라서 선택적 매개 변수를 사용하려면 기본값을 뒤에서부터 넣어야한다.
            // 대신, 기본값이 없는 매개변수에 값을 명시했다면 상관없다.

        }

        
        // 반환 인자 void
        //public static void PrintProfile(string name, string phone) 
        //{
        //    // 프로필 출력
        //    if (string.IsNullOrEmpty(name)) 
        //    {
        //        Console.WriteLine($"이름을 정확히 입력하세요.");
        //        return;
        //    }

        //    Console.WriteLine($"이름 : {name}, 폰번호 : {phone}");
        //}


        // 반환 인자 int
        //public static int PrintProfile(string name, string phone)
        //{
        //    // 프로필 출력
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        Console.WriteLine($"이름을 정확히 입력하세요.");
        //        return -1;
        //    }
           
        //    Console.WriteLine($"이름 : {name}, 폰번호 : {phone}");
        //    Console.WriteLine();
        //    return 0;
        //}


        // 선택적 매개변수
        public static int PrintProfile(string name, string phone = "010-5588-7777")
        {
            // 프로필 출력
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"이름을 정확히 입력하세요.");
                return -1;
            }

            Console.WriteLine($"이름 : {name}, 폰번호 : {phone}");
            Console.WriteLine();
            return 0;
        }
    }
}
