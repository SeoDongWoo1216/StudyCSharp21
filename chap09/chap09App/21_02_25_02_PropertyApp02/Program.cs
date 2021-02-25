using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_25_02_PropertyApp02
{
    // 프로퍼티 2탄
    // 1탄에서는 변수이름이 value로 사용해서 코드가 복잡한데, 깔끔하게 정리해봅시다.
    
    class BirthdayInfo  // 생일 정보를 담는 클래스
    {
        private string name;
        private DateTime birthday;

        // 프로퍼티 사용
        public string Name   // 프로퍼티는 인자를 받는 매개변수가 없으므로 value 키워드로 대체할 수 있다.
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public DateTime Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }


        // 일반 Get, Set 메서드 사용
        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public DateTime GetBirthday()
        {
            return this.birthday;
        }

        public void SetBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 일반 Get, Set 메서드 사용
            Console.WriteLine($"일반 Get, Set 메서드 사용");
            BirthdayInfo info = new BirthdayInfo();
            info.SetName("홍길동");
            info.SetBirthday(new DateTime(1990, 1, 8));

            Console.WriteLine($"이름 : {info.GetName()}");
            Console.WriteLine($"생일 : {info.GetBirthday()}");
            Console.WriteLine();


            // 프로퍼티 사용
            Console.WriteLine($"프로퍼티 사용");
            BirthdayInfo info2 = new BirthdayInfo();
            info2.Name = "홍길순";
            info2.Birthday = new DateTime(1992, 3, 16);

            Console.WriteLine($"이름 : {info2.GetName()}");
            Console.WriteLine($"생일 : {info2.GetBirthday()}");
        }
    }
}
