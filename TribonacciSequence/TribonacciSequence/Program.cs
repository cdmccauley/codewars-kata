using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonacciSequence
{
    class Program
    {
        public static double[] Tribonacci(double[] signature, int n)
        {
            double[] sequence;

            if (n == 0)
                return sequence = new double[] { n };
            else if (n <= signature.Length)
            {
                sequence = new double[n];
                Array.Copy(signature, sequence, n);
                return sequence;
            }
            else
            {
                double[] stage = new double[3];
                sequence = new double[n];

                signature.CopyTo(stage, 0);
                signature.CopyTo(sequence, 0);

                for (int i = 3; i < sequence.Length; ++i)
                {
                    sequence[i] += stage.Sum();
                    stage[0] = stage[1];
                    stage[1] = stage[2];
                    stage[2] = sequence[i];
                }

                return sequence;
            }
        }

        static void Main(string[] args)
        {
            foreach (double number in Tribonacci(new double[] { 11, 10, 7 }, 1))
                Console.Write(number + ", ");

            Console.WriteLine();
            foreach (double number in Tribonacci(new double[] { 1, 1, 1 }, 10))
                Console.Write(number + ", ");

            Console.WriteLine();
            foreach (double number in Tribonacci(new double[] { 0, 0, 1 }, 10))
                Console.Write(number + ", ");

            Console.WriteLine();
            foreach (double number in Tribonacci(new double[] { 0, 1, 1 }, 10))
                Console.Write(number + ", ");

            Console.ReadKey();
        }
    }
}
