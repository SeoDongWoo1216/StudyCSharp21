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

        }

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

        public static int PrintProfile(string name, string phone)
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
