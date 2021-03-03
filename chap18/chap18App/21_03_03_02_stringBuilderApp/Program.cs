using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_03_02_stringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello World\n");
            // sb[6] = 'N';                            // 배열처럼 값 수정가능. 그러나 권장 안함.
            sb.Append("My name is DongWoo\n");
            sb.Append("I'm 27 years old.\n");          // 특수문자 '가 그냥 들어가도됨.(원래는 \' 로 출력해야함)
            sb.Append("Book price is 30,000 won. \n");
            sb.Insert(6, "New ");                      // Hello New World 가 출력,  6번째부터 ""에 들어간 문자열 삽입
            sb.Replace("Book", "책");                  // 첫번째 문자열을 두번째 문자열로 바꿈

            Console.WriteLine(sb);


        }
    }
}
