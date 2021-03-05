﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _21_03_05_03_SideTaskApp
{
    class SideTask
    {
        int Count { get; set; }
        public SideTask(int count)
        {
            this.Count = count;
        }

        public void CountDown()
        {
            try
            {
                while (Count > 0)
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {Count} 남음"); // 스레드의 번호 : count 남음으로 출력
                    Count--;
                    Thread.Sleep(10);
                }
                Console.WriteLine($"Count : {Count}");  // 0
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine($"스레드 임의종료 예외 발생 : {ex.Message}");
                Thread.ResetAbort();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"스레드 예외 발생 : {ex.Message}");
            }
            // 큰수에서 작은수까지 카운트
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread th = new Thread(task.CountDown);
            th.IsBackground = false;  // 이 스레드가 종료되기 전까지는 프로세스가 끝나지 않음
            // true인 경우, 백그라운드 스레드가 돌고있는 상태에도 메인 스레드가 끝나면 백그라운드 스레드도 같이 종료.
            SideTask task2 = new SideTask(100);
            Thread th2 = new Thread(task2.CountDown);   // IsBackground의 기본값은 false임.

            
            Console.WriteLine("스레드 시작!");
            th.Start();
            th2.Start();

            Thread.Sleep(100);   // 1초 슬립

            th2.Interrupt();     // 인터럽트
            Console.WriteLine("인터럽트!");

            //Console.WriteLine("임의 종료");
            //th.Abort();

            Console.WriteLine("종료 대기");    // 카운트다운 중간에 표시
            th.Join();
            th2.Join();

            Console.WriteLine("스레드/프로세스 종료!");
        }
    }
}
