using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_26_01_InterfaceTestApp
{
    // 인터페이스 : 다중상속의 단점을 보완해준다.
    
    /*
    class Ridable  // 탈것
    {
        public virtual void Ride()
        {
            Console.WriteLine("Run!");
       }
    }
    */

    interface ICar
    {
        void Run();
        void Ride();
    }

    interface IPlane
    {
        void Fly();
        void Ride();
    }

    class DroneCar : IPlane, ICar
    {
        public void Fly()
        {
            Console.WriteLine("드론카 날다!");
        }

        public void Ride()
        {
            Run();
            Fly();
        }

        public void Run()
        {
            Console.WriteLine("드론카 달린다!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DroneCar dreamCar = new DroneCar();
            dreamCar.Ride();
        }
    }
}
