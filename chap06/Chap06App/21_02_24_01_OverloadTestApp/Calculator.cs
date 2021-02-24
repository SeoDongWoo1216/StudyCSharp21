using System;

namespace _21_02_24_01_OverloadTestApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            // 오버로딩, 가변길이 매개변수
            Console.WriteLine("계산기!");

            int x = Calculator.Plus(3, 4);
            Console.WriteLine($"3 + 4 = {x}");

            float y = Calculator.Plus(3.14f, 5.6f);  // float형만 받는 Plus 메서드가 필요함.
            Console.WriteLine($"3.14f + 5.6f = {y}");

            Console.WriteLine($"3.14 + 5.6 = {Calculator.Plus(3.14, 5.6)}");  // f가없으면 double형 : double형 Plust 메서드가 필요함.

            Console.WriteLine($"3.14 + 5.6 = {Calculator.Plus(3.14, "5")}");

            int z = Calculator.Plus(7, 8, 9);

            int total = 0;
            total = Sum(1, 2, 3);
            Console.WriteLine($"합계는 {total} 입니다.");
        }

        private static int Sum(int v1, int v2, int v3)
        {
            int result = v1 + v2 + v3;
            return result;
        }

        private static int Sum(int v1, int v2)
        {
            int result = v1 + v2;
            return result;
        }

        // 메서드가 잘 짜여졌는지는 참조 개수를보면 알 수 있다.(0개면 필요없거나 연결이 안됬다는 뜻)

        // x
        private static int Plus(int v1, int v2)
        {
            int result = v1 + v2;
            return result;
        }

        // y
        private static float Plus(float v1, float v2)
        {
            float result = v1 + v2;
            return result;
        }

       
        private static double Plus(double v1, double v2)
        {
            double result = v1 + v2;
            return result;
        }

        private static double Plus(double v1, string v2)
        {
            double.TryParse(v2, out double p2);
            double result = v1 + p2;
            return result;
        }

        // z
        private static int Plus(int v1, int v2, int v3)
        {
            int result = v1 + v2 + v3;
            return result;
        }




        // 밑은 절대 안되는 것임.
        //private static int Plus(double v1, string v2) // 이미 int로 받는게있는데 형변환한다고해서 컴파일러는 구분하지못함.
        //{
        //    long result = v1 + v2;
        //    return result
        //}



    }
}
