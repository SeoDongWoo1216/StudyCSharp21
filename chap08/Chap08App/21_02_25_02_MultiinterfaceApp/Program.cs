using System;

namespace _21_02_25_02_MultiinterfaceApp
{
    interface IRunable  // 자동차 종류
    {
        void Run();
    }

    interface IFlyable  // 비행기 종류
    {
        void Fly();
    }

    class DroneCar : IRunable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("날아!");
            Console.WriteLine();
        }

        public void Run()
        {
            Console.WriteLine("달려!");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("드론카!");

            DroneCar dreamCar = new DroneCar();
            dreamCar.Run();
            dreamCar.Fly();


            Console.WriteLine("카로 변경(interface)");
            IRunable car = dreamCar;
            car.Run();
            // car.Fly();   // 오류(IRunable에는 Fly가 없음)

            Console.WriteLine("비행기로 변경(interface)");
            IFlyable plane = dreamCar;
            plane.Fly();
            // plane.Run(); // 오류(IFlyable에는 Run이 없음)

        }
    }
}
