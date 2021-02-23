using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_23_05_ForeachTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"For 문");
            int [] sources = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};


            for (int i = 0; i <= sources.Length; i++)
            {
                Console.WriteLine($"sources [{i}]) = sources[{i}]");
            }
            Console.WriteLine();

            // foreach
            Console.WriteLine($"Foreach 문");
            foreach (var item in sources)
            {
                Console.WriteLine($"sources[] = {item}");
            }
            Console.WriteLine();


            // 있는 와중에 생일이 3월인사람?
            foreach (var item in sources)
            {
                if(item % 3 ==0)
                    Console.WriteLine($"3의 배수 : {item}");
                else
                    continue;
            }
          
        }

    }
}
