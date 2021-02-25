using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_25_03_OverrideTestApp
{
    // 오버라이딩 : 

    class ArmorSuite
    {
        public virtual void Initialize()  // virtual은 자식 클래스에서 재정의 할꺼라는 뜻.
        {
            Console.WriteLine("ArmorSuite 초기화!");
            Console.WriteLine();
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("ArmorSuite개량 초기화!");
            Console.WriteLine("리펄서건 장착!");
            Console.WriteLine();
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();  // 부모가 가지고있는 Initialize 실행하고 자식클래스 실행 // 실무에서는 주석처리하고도 실행함
            Console.WriteLine("ArmorSuite개량 Warmachine 초기화!");
            Console.WriteLine("Double-Barrel 캐논 장착!");
            Console.WriteLine("Micro-Rocket  런처 장착!");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArmorSuite 생산");
            ArmorSuite suite = new ArmorSuite();
            suite.Initialize();

            Console.WriteLine("WarMachine 생산");
            WarMachine machine = new WarMachine();
            machine.Initialize();
            Console.WriteLine();

            Console.WriteLine("IronMan    생산");
            IronMan ironMan = new IronMan();
            ironMan.Initialize();
            Console.WriteLine();
        }
    }
}
