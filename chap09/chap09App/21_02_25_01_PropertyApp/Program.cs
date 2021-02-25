using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_25_01_PropertyApp
{
    // 프로퍼티
    // 데이터를 걸러주기위해 GetValue, SetValue를 생성해주었다.
    // 하지만 value만이아니라 변수가 그만큼 많아지면 Get, Set 메서드를 또 만들어주어야한다.
    // 그렇게하는게 귀찮으므로 프로퍼티를 사용한다.

    class MyClass
    {
        private int     iValue;
        // public int value; // 0 ~ 120까지의 값만 입력받는 멤버 변수
        private double  dZeta;
        private float   fPng;
        private String  strVal;
        private int     inCode;  // value값에대해 GetValue, SetValue를 생성했지만, 변수가 더 많아지면 그만큼 더 만들어야할것이다.

        // 더 많이 만드는 귀찮음을 해결하기위해 프로퍼티를 사용한다.

        public int IValue 
        {
            // 들어간 값은 파란색깔의 키워드 value로 나옴
            get
            {
                return this.iValue;
            }
            set 
            {
                if (value < 0)
                    this.iValue = 0;
                else if (value > 120)
                    this.iValue = 120;
                else
                    this.iValue = value;

            }
        }

        public MyClass(int value) // 초기화하는 생성자(객체 선언때 값을 넣어줘야함)
        {
            IValue = iValue;
            // this.iValue = value;
            // this.SetValue(value);
        }

        #region 
        //public int GetValue()  // private로인해 클래스밖에서는 value에 접근할 수 없다. 그래서 접근할 수 있는 메서드를 생성해줌.
        //{
        //    return this.iValue;
        //}

        //public void SetValue(int value)  // 정수 value의 값을 걸러주는 메서드
        //{
        //    if(value < 0)
        //    {
        //        this.iValue = 0;
        //    }
        //    else if(value > 120)
        //    {
        //        this.iValue = 120; 
        //    }
        //    else
        //    {
        //        this.iValue = value;
        //    }
        //}
        #endregion 

        public void PrintValue()
        {
            Console.WriteLine($"값은 {this.IValue} 입니다.");
            //Console.WriteLine($"값은 {this.iValue} 입니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass aMyClass = new MyClass(1500);
            aMyClass.PrintValue();

            //GetValue, SetValue 사용 -> 귀찮게 일일이 선언해주어야함.
            //aMyClass.SetValue(1500);
            //aMyClass.PrintValue();
            //Console.WriteLine($"현재 온도는 {aMyClass.GetValue()}도 입니다. ");


            // 프로퍼티 사용
            aMyClass.IValue = 1200;  // 프로퍼티는 변수 선언하듯이 사용함.
            aMyClass.PrintValue();
            Console.WriteLine($"현재 온도는 {aMyClass.IValue}도 입니다. ");
        }
    }
}
