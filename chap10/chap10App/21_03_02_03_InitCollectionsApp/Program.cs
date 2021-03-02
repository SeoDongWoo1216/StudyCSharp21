using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_02_03_InitCollectionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("ArrayList");
            int[] arr = { 123, 456, 789 };
            ArrayList list = new ArrayList(arr);
            foreach (var item in list)
            {
                Console.WriteLine($"ArrayList : {item}");
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("스택");
            Stack stack = new Stack(arr);
            foreach (var item in stack)
            {
                Console.WriteLine($"Stack : {item}");
            }

            Console.WriteLine("-----------------------------------------");
            ArrayList list2 = new ArrayList() { 10, 20, 30 };
            foreach (var item in list2)
            {
                Console.WriteLine($"ArrayList2 : {item}");
            }
        }
    }
}
