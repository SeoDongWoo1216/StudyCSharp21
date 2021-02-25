using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_25_04_PartialClassApp
{
    partial class MyClass
    {
        public void Method3() { Console.WriteLine("Method3"); }
        public void Method4() { Console.WriteLine("Method4"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass aclass = new MyClass();
            aclass.Method1();
            aclass.Method2();
            aclass.Method3();
            aclass.Method4();
        }
    }
}
