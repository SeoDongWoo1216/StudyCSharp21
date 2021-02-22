using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_02_22_05_IntConversionApp
{
    class ConvTest
    {
        static void Main(string[] args)
        {
            // 형변환 예제

            short shMaxVal = short.MaxValue;
            int inCastVal = 0;

            inCastVal = shMaxVal;
            Console.WriteLine($"short값 변환한 int 값은 {inCastVal}");
            
            inCastVal += 5;
            // short shCastVal = inCastVal; // short의 최대값은(2바이트) 32767인데, 그보다 큰 값을 더 할당해주려고하니 오류가 뜰것임.

            short shCastVal = (short)inCastVal;  
            Console.WriteLine($"short값 변환한 int 값은 {shCastVal}");  // 오버플로우
            Console.WriteLine();
            // short로 형변환을 해주면 오류는 없어지지만, 값은 범위를 넘었으므로 오버플로우가 발생한다.


            /////////////////////////////////////////////////////////////////////////////////////////////


            float flVal = 3.141592f;  // float형은 f or F 를 써주어야한다.
            inCastVal = (int)flVal;   // float형은 int에 대입하기위해 int형으로 형변환
            Console.WriteLine($"float 변환한 int 값은 {inCastVal}");  // int형은 정수형이므로 소수점은 전부 날리고 정수값만 저장된 것을 확인할 수 있음.

            double dlVal = inCastVal;  // int형에서 다시 소수점형인 double형에 대입
            Console.WriteLine($"int 변환한 double 값은 {dlVal}");     // 다시 소수점형 변수에 넣어도 소수점은 돌아오지 않음.
            Console.WriteLine();


            /////////////////////////////////////////////////////////////////////////////////////////////
            

            object obj = 20;               // 박싱   : 오브젝트에 값 초기화
            int inUnboxingVal = (int)obj;  // 언박싱 : 오브젝트에서 다른 변수에 형변환에서 대입


            /////////////////////////////////////////////////////////////////////////////////////////////


            string strVal = "200";
            // int result = strVal * 3;          // strVal은 문자열이니 문자열 * 숫자로 인식하여 오류가 뜬다.
            int result = int.Parse(strVal) * 3;  // int.Parse 을 통해 문자열을 숫자로 형변환 시킬 수 있다.
            Console.WriteLine($"200 * 3 = {result}");





        }
    }
}
