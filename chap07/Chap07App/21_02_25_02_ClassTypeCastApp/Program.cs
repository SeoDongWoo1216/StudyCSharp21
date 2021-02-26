﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_25_02_ClassTypeCastApp
{

    // 클래스 형변환
    // 값의 형변환도 작은게 큰거로 들어가면 문제없지만, 큰게 작은거로 들어가는것은 안된다.
    // 클래스도 자식이 부모로 들어가는건 문제없지만, 부모가 자식으로 들어가는것은 안된다.
    // 하지만, 부모가 자식으로갈때 명시적 형변환을 이용하면 형변환이 가능해진다.

    class 포유류
    {
        public void 키우다()
        {
            Console.WriteLine($"키우다()");
        }
    }

    class 강아지 : 포유류
    {
        public void 멍멍()
        {
            Console.WriteLine("멍멍()");
        }
    }

    class 고양이 : 포유류
    {
        public void 야옹()
        {
            Console.WriteLine("야옹()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            포유류 a포유류 = new 포유류();
            a포유류.키우다();

            강아지 쭈쭈;
            강아지 뽀삐 = null;

            a포유류 = new 강아지();               // 형변환(상위 클래스 포유류를 하위클래스 강아지로 형변환이 되었음)
            a포유류 = new 고양이();
            // a포유류.멍멍();                    // 부모클래스로 바꼈기때문에 자식 클래스의 메서드 실행 불가

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            // is as 문
            // is는 객체가 해당 형식에 맞는지 검사하고 bool 을 반환한다.

            if (a포유류 is 강아지) // 포유류가 강아지인지 물어보는 조건문
            {
                Console.WriteLine("쭈쭈가 실행되었다");
                쭈쭈 = a포유류 as 강아지;  // 포유류가 강아지로 형변환이 잘됬는지 보는 조건문(실패했으면 NULL 반환)
                쭈쭈.멍멍();
            }

            if (뽀삐 is 포유류) // 뽀삐가 포유류인지 물어보는 조건문
            {
                Console.WriteLine("뽀삐가 실행되었다");
                뽀삐 = a포유류 as 강아지;  
                뽀삐.키우다();
                뽀삐.멍멍();
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //강아지 뽀삐 = new 포유류();         // 자식이 부모로 바뀌는건 가능한데 부모가 자식으로 바뀌는건 안된다.

            //강아지 뽀삐 = (강아지)new 포유류(); // 하지만 명시적 형변환을 이용하면 코드상으로는 가능은한데, 실행하면 오류가 뜬다.
            //고양이 로미 = (고양이)new 포유류();
            //뽀삐.멍멍();                        // 자식클래스로 넘어왔고, 상속관계도 유효하기때문에 자식, 부모 클래스의 메서드 호출 가능

            // 명시적 형변환은 오류가뜨지만, 잠시 형변환을 통해 모든 기능들을 모았다가 조건문으로 나누는 방법등으로 쓰임.

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////




        }
    }
}