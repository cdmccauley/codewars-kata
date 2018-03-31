using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_sum_of_numbers
{
    class Program
    {
        public static int GetSum(int a, int b)
        {
            int sum = 0;

            if (a == b)
            {
                return a;
            }
            else if (a < b)
            {
                for (int i = a; i <= b; ++i)
                {
                    sum += i;
                }
                return sum;
            }
            else
            {
                for (int i = b; i <= a; ++i)
                {
                    sum += i;
                }
                return sum;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(0, 1));
            Console.WriteLine(GetSum(0, -1));

            Console.ReadKey();
        }
    }
}
