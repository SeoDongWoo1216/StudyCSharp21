using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_24_01_ClassTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("객체 사용");

            //// Cat cat1;          // 이 상태에서 cat1을 선언하고 사용하려고하면 할당되지않았다면서 오류가 뜸.(초기화해줘야함)
            //Cat cat1 = new Cat(); // 객체의 실체(instance) 생성. new 를 통해 객체를 생성하고, 메서드에는 항상 ()가 있어야한다.
            //cat1.Name  = "야옹이1";
            //cat1.Color = "흰색";
            //cat1.Meow();

            //Cat kitty = new Cat();
            //kitty.Name  = "헬로키티";
            //kitty.Color = "하얀색";
            //kitty.Meow();

            //Cat nero = new Cat();
            //nero.Name   = "검은고양이 네로";
            //nero.Color  = "검은색";
            //nero.Gender = "남자";
            //nero.Meow();

            Cat yomi = new Cat("요미", "흰색", "암컷");
            yomi.Meow();
        }
    }

    class Cat  
    {
        public Cat() { }  // 객체 생성자는 컴파일러가 자동으로 만들어줌.
        
        // ~ Cat() // 종료자인데 더 이상 필요없음(사용안해도됨)
        //public Cat(string _name, string _color) // 생성자, 멤버 필드
        //{
        //    Name  = _name;
        //    Color = _color;
        //}

        public Cat(string Name)
        {
            this.Name = Name;
        }

        public Cat(string Name, string Color) : this(Name) // 이름이 같은 변수들을 구분하기위해 this를 표시한다.
        {
            this.Color = Color;
        }

        //public Cat(string _name, string _color, string _gender)  // 생성자 오버로딩
        //{
        //    Name = _name;
        //    Color = _color;
        //    Gender = _gender;
        //}

        public Cat(string Name, string Color, string _gender) : this(Name, Color)
        {
            Gender = _gender;

        }

        public string Name;    // 이름   // ★★특성, 속성, 변수★★
        public string Color;   // 색상   // Cat안에 있기때문에 멤버변수 라고도 부른다.
        public string Gender;  // 성별

        public void Meow()   // ★★행위, 기능, 메서드★★
        {
            Console.WriteLine($"{this.Name}(색상:{this.Color} / 성별{this.Gender}) : 야옹!");
        }
    }
}
