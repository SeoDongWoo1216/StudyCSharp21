using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_25_05_InheritTestApp
{
    // 상속
    // 소멸자는 자식 클래스 -> 부모 클래스 순서로 (작은거에서 큰순서로 소멸)
    class Parent   // 부모 클래스
    {
        protected string Name;   // private는 지금 클래스만 가능, protected는 상속된 클래스까지 가능

        public Parent(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Parent() 생성자");
            Console.WriteLine();
        }

        //~Parent()  // 소멸자
        //{
        //    Console.WriteLine($"{this.Name}.Parent() 소멸자");
        //    Console.WriteLine();
        //}

        public void ParentMethod()
        {
            // ...
            Console.WriteLine($"{this.Name}.ParentMethod() 실행");
        }

        public void ParentMethod2()
        {
            // ...
            Console.WriteLine($"{this.Name}.ParentMethod2() 실행");
        }


    }


    class Child : Parent
    {
        // 이게 실행되면 부모클래스를 실행하겠다는 뜻임.
        public Child(string Name) : base(Name) // this처럼 base는 부모클래스의 생성자를 먼저 실행하고 내 클래스를 실행하겠다는 뜻
        {
            Console.WriteLine($"{this.Name}.Child() 생성자");
            Console.WriteLine();
        }

        //~Child()  // 소멸자
        //{
        //    Console.WriteLine($"{this.Name}.Child() 소멸자");
        //    Console.WriteLine();
        //}

        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.ChildMethod()실행");
        }

        public void ChildMethod2()
        {
            Console.WriteLine($"{this.Name}.ChildMethod2()실행");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent("부모");
            p.ParentMethod();  // 부모 클래스 메서드 실행
            Console.WriteLine("------------------------------------------");

            Child c = new Child("자식");
            c.ParentMethod();  // 자식 클래스에서 부모의 메서드 실행
            Console.WriteLine("------------------------------------------");

            c.ChildMethod();   // 자식 클래스 메서드 실행
            Console.WriteLine("------------------------------------------");

            c.ChildMethod2();
            Console.WriteLine("------------------------------------------");

            c.ParentMethod2();
            Console.WriteLine("------------------------------------------");
        }
    }
}
