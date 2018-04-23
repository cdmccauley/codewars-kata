using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace csharp_longest_word
{
    class Program
    {
        public static string LongestWord(string sen)
        {
            string[] words = Regex.Matches(sen, @"\b\w+\b").Cast<Match>().Select(m => m.Value).ToArray();

            return words.OrderByDescending(s => s.Length).First();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(LongestWord("fun&!! time"));
            Console.WriteLine(LongestWord("I love dogs"));

            Console.ReadKey();
        }
    }
}
