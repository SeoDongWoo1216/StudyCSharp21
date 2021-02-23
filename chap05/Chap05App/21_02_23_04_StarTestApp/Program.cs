using System;

namespace _21_02_23_04_StarTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // for문을 이용한 예제 풀어보기
            Console.WriteLine("별모양 찍기");
            Console.WriteLine();


            #region 25개 찍기(기본형)

            //for (int i = 0; i < 5; i++)
            //{
            //    for(int j = 0; j < 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 삼각형 찍기

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5 - i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            
            #region 삼각형 찍기2

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

          
            #endregion

        }
    }
}
