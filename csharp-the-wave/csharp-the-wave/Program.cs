using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_the_wave
{
    class Program
    {
        public static List<string> wave(string str)
        {
            List<string> theWave = new List<string>();
            char[] currentWave;

            if (str != string.Empty)
            {
                currentWave = str.ToCharArray();

                for(int i = 0; i < currentWave.Length; ++i)
                {
                    if (Char.IsLetter(currentWave[i]))
                    {
                        currentWave[i] = Char.ToUpper(currentWave[i]);
                        theWave.Add(new string(currentWave));
                        currentWave[i] = Char.ToLower(currentWave[i]);
                    }
                }

                return theWave;
            }
            else
            {
                return new List<string> { };
            }
        }

        static void Main(string[] args)
        {
            foreach (string waver in wave("hello"))
                Console.WriteLine(waver);

            Console.ReadKey();
        }
    }
}
