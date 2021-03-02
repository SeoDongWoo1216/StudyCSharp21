using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_02_03_GenericClassApp
{
    // 제네릭 클래스 예제
    class Array_Generic<T>   // 클래스에 어떤 타입이든 받을 수 있다.
    { 
        private T[] array;

        public Array_Generic()
        {
            array = new T[10];
        }

        public T GetElement(int index)
        {
            return array[index];
        }

        public int Legnth
        {
            get
            {
                return array.Length;
            }
        }
    }

    //class Array_Int
    //{
    //    private int[] array;

    //    public Array_Int()
    //    {
    //        array = new int[10];
    //    }

    //    public int GetElement(int index)
    //    {
    //        return array[index];
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Array_Generic<int> array = new Array_Generic<int>();

            Array_Generic<string> strArr = new Array_Generic<string>();
        }
    }
}
