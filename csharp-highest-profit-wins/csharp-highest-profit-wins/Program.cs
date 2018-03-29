using System;
using System.Linq;

namespace csharp_highest_profit_wins
{
    class Program
    {
        public static int[] minMax(int[] lst)
        {
            return new int[] { lst.Min(), lst.Max() };
        }

        static void Main(string[] args)
        {
            int[] methodOutput;

            methodOutput = minMax(new int[] { 1, 2, 5, -1, 12, 20 });  // -1, 20
            methodOutput.ToList().ForEach(Console.WriteLine);

            methodOutput = minMax(new int[] { 1, 2, 3, 4, 5 });  // 1, 5
            methodOutput.ToList().ForEach(Console.WriteLine);

            methodOutput = minMax(new int[] { 1, 2, -3, 4, 5 });  // -3, 5
            methodOutput.ToList().ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
