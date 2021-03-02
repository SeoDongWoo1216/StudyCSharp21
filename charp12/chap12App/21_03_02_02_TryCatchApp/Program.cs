using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_02_02_TryCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            int x = 108, y = 0;
            int result = 0;

            try
            {
               
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i} 번째 값 : {arr[i]}");
                }

                result = x / y;
                Console.WriteLine($"결과는 {result}");
            }
            catch (IndexOutOfRangeException ex)  // 오브젝트가 최상위 클래스면, Exception은 최상위 예외임
            {
                Console.WriteLine($"예외발생 : {ex.Message} ");
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine($"예외발생 : {ex.Message} ");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("나머지 일처리 계속..");  // try~catch문으로 안잡으면 이 출력문구가 뜨지 않음.
            Console.WriteLine();


            
            try
            {
                //string strVal = "Hello World!";
                string strVal = null;
                string splitVal = strVal.Substring(6, 5);
                Console.WriteLine($"자른 문자 : {splitVal}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"원본 문자열이 비어있습니다. 값을 입력하세요 {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"원본 문자열을 초기화 하세요. {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"기타 예외 발생{ex.Message}");
            }
            Console.WriteLine("일처리 또있음...");
        }
    }
}
