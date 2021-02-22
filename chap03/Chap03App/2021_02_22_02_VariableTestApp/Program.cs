using System;

namespace VariableTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int iv1 = 30, iv2 = 40;
            //int result = iv1 + iv2;
            //Console.WriteLine(result);

            sbyte sbMinval = sbyte.MinValue;
            sbyte sbMaxval = sbyte.MaxValue;
            //Console.WriteLine("{0}, {1}", sbMinval, sbMaxval);
            Console.WriteLine($"Sbyte  최소, 최대값은 {sbMinval}, {sbMaxval} 입니다.");

            short shMinval = short.MinValue;
            short shMaxval = short.MaxValue;
            Console.WriteLine($"short  최소, 최대값은 {shMinval}, {shMaxval} 입니다.");

            ushort ushMinval = ushort.MinValue;
            ushort ushMaxval = ushort.MaxValue;
            Console.WriteLine($"ushort 최소, 최대값은 {ushMinval}, {ushMaxval} 입니다.");

            int iMinval = int.MinValue;
            int iMaxval = int.MaxValue;
            Console.WriteLine($"int    최소, 최대값은 {iMinval}, {iMaxval} 입니다.");

            uint uiMinval = uint.MinValue;
            uint uiMaxval = uint.MaxValue;
            Console.WriteLine($"uint   최소, 최대값은 {uiMinval}, {uiMaxval} 입니다.");

            long lMinval = long.MinValue;
            long lMaxval = long.MaxValue;
            Console.WriteLine($"long   최소, 최대값은 {lMinval}, {lMaxval} 입니다.");

            ulong ulMinval = ulong.MinValue;
            ulong ulMaxval = ulong.MaxValue;
            Console.WriteLine($"ulong  최소, 최대값은 {ulMinval}, {ulMaxval} 입니다.");



        }
    }
}
