using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_find_the_stray_number
{
    class Program
    {
        public static int Stray(int[] numbers)
        {
            List<int> numList = numbers.ToList<int>();

            numList.Sort();
            int first = numList[0];
            numList.RemoveAt(0);
            if (!numList.Contains(first))
                return first;
            else
            {
                foreach (int number in numList)
                    if (number != first)
                        return number;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Stray(new int[] { 1, 1, 2 }));

            Console.ReadKey();
        }
    }
}
