using System;
using System.Collections.Generic;

namespace csharp_vasya_clerk
{
    class Program
    {
        public static string Tickets(int[] peopleInLine)
        {
            Dictionary<int, int> bills = new Dictionary<int, int>();
            int registerTotal = 0;
            const int TICKET_PRICE = 25;

            bills.Add(25, 0);
            bills.Add(50, 0);
            bills.Add(100, 0);

            foreach (int bill in peopleInLine)
            {
                if ((bill - TICKET_PRICE) > registerTotal)
                    return "NO";
                else
                {
                    registerTotal += bill;
                    ++bills[bill];
                    switch (bill)
                    {
                        case 100:
                            if (bills[50] >= 1 && bills[25] >= 1)
                            {
                                --bills[50];
                                --bills[25];
                            }
                            else if (bills[25] >= 3)
                                bills[25] -= 3;
                            else
                                return "NO";
                            break;
                        case 50:
                            if (bills[25] >= 1)
                                --bills[25];
                            else
                                return "NO";
                            break;
                    }
                }
            }
            return "YES";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Tickets(new int[] { 25, 25, 50, 50 }));
            Console.WriteLine(Tickets(new int[] { 25, 100 }));
            Console.WriteLine(Tickets(new int[] { 25, 25, 50, 50, 100 }));
            Console.WriteLine(Tickets(new int[] { 25, 25, 25, 25, 25, 100, 100 }));
            Console.WriteLine(Tickets(new int[] { 25, 25, 25, 25, 25, 25, 25, 50, 50, 50, 100, 100, 100, 100 }));

            Console.ReadKey();
        }
    }
}
