using System;
using System.Threading;

namespace _21_03_05_01_FirstThread
{
    class Program
    {
        static void DoSomething()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);    // 10 / 1000초 동안 멈춤
            }
        }
        static void DoSomethingHappened()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"DoSomethingHappened : {i}");
                Thread.Sleep(10);    // 10 / 1000초 동안 멈춤
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(DoSomething));
            Thread thread1 = new Thread(DoSomethingHappened);

            Console.WriteLine("스레드 시작!");
            thread.Start();
            thread1.Start();

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Main Thread : {i}");
                Thread.Sleep(10);
            }

            thread.Abort();
            Console.WriteLine("스레드 종료 대기...");
            thread.Join();
            thread1.Join();

            Console.WriteLine("프로세스 종료");

        }
    }
}
