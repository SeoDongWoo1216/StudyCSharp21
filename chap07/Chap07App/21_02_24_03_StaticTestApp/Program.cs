using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_24_03_StaticTestApp
{
    class TestClass
    {
        public static int number;
        // public int number;
        public float fnum;

        public static float ProcSomething()
        {
            Console.WriteLine($"{number}, 뭔가한다");
            return 1.0f;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 정적 필드, 정적 메소드 : static이 없으면 항상 new를 사용해주어야함.

            TestClass aCls = new TestClass();
            TestClass.number = 10;               // aCls, bCls는 각각 다른 건데 똑같이 하려면 static을 사용하면된다.
            //aCls.number = 10;       
            aCls.fnum = 3.25f;

            TestClass bCls = new TestClass();
            //bCls.number = 10;
            bCls.fnum = 4.87f;

            // aCls.ProcSomething();
            // bCls.ProcSomething();            // 같은 구문을 두번 쓸것을 한번만 써줄수도있음.
            TestClass.ProcSomething();          // static을 이용해서 Console.WriteLine처럼 new 선언없이 바로 호출해줄 수 있다.
        }
    }
}
