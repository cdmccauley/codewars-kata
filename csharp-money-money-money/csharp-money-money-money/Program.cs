using System;

namespace csharp_money_money_money
{
    class Program
    {
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            double balance = principal, yearsGrowth, yearsTax;
            int years = 0;

            if (balance != desiredPrincipal)
                while (balance <= desiredPrincipal)
                {
                    yearsGrowth = balance * interest;
                    yearsTax = yearsGrowth * tax;
                    balance += yearsGrowth - yearsTax;
                    ++years;
                }

            return years;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CalculateYears(1000, 0.05, 0.18, 1100));
            Console.WriteLine(CalculateYears(1000, 0.05, 0.18, 1000));
            Console.WriteLine(CalculateYears(1000,0.01625,0.18,1200));
            
            Console.ReadKey();
        }
    }
}
