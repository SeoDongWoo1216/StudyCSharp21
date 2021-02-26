using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_26_01_TupleTestApp
{
    // 튜플
    class Program
    {
        static void Main(string[] args)
        {
            var tuple1 = (1, "서동우", "010-1111-1111", "대한민국 어딘가", true);
            var tuple2 = (Idx: 2, Name: "홍길동", Phone: "010-2222-2222-", Address: "한반도 양지마른땅", marrige: false);

            Console.WriteLine($"{tuple1.Item1} / {tuple1.Item2} / {tuple1.Item3} / {tuple1.Item4} / {tuple1.Item5}");
            Console.WriteLine($"{tuple2.Item1} / {tuple2.Item2} / {tuple2.Item3} / {tuple2.Item4} / {tuple2.Item5}");
            Console.WriteLine($"{tuple2.Idx} / {tuple2.Name} / {tuple2.Phone} / {tuple2.Address} / {tuple2.marrige}");
        }
    }
}
