using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_23_06_InfiniteLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            long idx = 0;
            for (; ; )  // 무한루프
            {
                Console.WriteLine($"idx = {idx++}");
            }
        }
    }
}
