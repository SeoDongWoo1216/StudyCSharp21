using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_24_04_AccessModifierTestApp
{
    class Boiler
    {
        // public, protected, private, internal(빈도는 별로)
        private int temp = 5;  // 물 온도

        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60)
            {
                Console.WriteLine("물의 온도가 일정 온도를 벗어났습니다. 59도로 맞춥니다.");
                this.temp = 59;
            }
            else
            {
                this.temp = temp;
            }
           
        }
        
        public int GetTemp()
        {
            return this.temp;
        }

        public void TurnOnBoiler()
        {
            Console.WriteLine("보일러를 킵니다.");
        }

        public void TurnOffBoiler()
        {
            Console.WriteLine("보일러를 끕니다.");
        }

    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            var currTemp = kitturami.GetTemp();
            Console.WriteLine($"현재 온도는 {currTemp} 입니다.");
            kitturami.SetTemp(40);
            kitturami.TurnOnBoiler();
            kitturami.SetTemp(59);

            if (kitturami.GetTemp() >= 59)
            {
                kitturami.TurnOffBoiler();
            }

            //kitturami.GetTemp();
            //kitturami.temp = 45;
            //kitturami.TurnOnBoiler();
            //Console.WriteLine($"현재 온도는 {kitturami.temp}");
            //kitturami.temp = 70;
            //Console.WriteLine();

            
        }
    }
}
