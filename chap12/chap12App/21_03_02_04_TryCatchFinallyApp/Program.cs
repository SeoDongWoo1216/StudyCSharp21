using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_02_04_TryCatchFinallyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("제수를 입력하세요 : ");  // 제수 : 나눠지는 큰 값
                string temp = Console.ReadLine();   // ReadLine은 항상 string으로 입력받음.
                int divisor = int.Parse(temp);

                Console.Write("피제수를 입력하세요 : ");
                temp = Console.ReadLine();
                int divdend = int.Parse(temp);
                Console.WriteLine();

                Console.WriteLine($"{divisor} / {divdend} = {Divide(divisor, divdend)}");    // 24 / 6 = 4
            }
            catch (NotImplementedException ex)  // 메서드 구현 안되있을때 예외
            {
                Console.WriteLine($"미구현 예외 발생 : {ex.Message}");
            }
            catch (FormatException ex)          // 숫자 아니고 문자입력했을때 예외
            {
                Console.WriteLine($"입력값 예외 발생 : {ex.Message}");
            }
            catch (DivideByZeroException ex)    // 0으로 나눴을때 예외
            {
                Console.WriteLine($"나누기 예외 발생 : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
            }

            finally
            {
                Console.WriteLine("\n예외 발생 유무와 상관없이 늘 실행되는 finally문");
            }
        }

        private static object Divide(int divisor, int divdend)
        {
            Console.WriteLine();
            Console.WriteLine("나누기 시작!");
            if (divdend == 0) throw new DivideByZeroException("피제수가 0이 입력되었습니다.");
            return divisor / divdend;
        }
    }
}
