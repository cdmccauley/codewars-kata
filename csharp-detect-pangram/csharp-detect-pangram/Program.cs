using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_detect_pangram
{
    class Program
    {
        public static bool IsPangram(string str)
        {
            List<char> charList = new List<char>();

            var pangramQuery =
                from character in charList
                group character by character into charGroup
                select charGroup.Key;

            foreach (char character in str.ToLower())
                if (Char.IsLetter(character))
                    charList.Add(character);

            return (pangramQuery.Count() == 26);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog."));

            Console.ReadKey();
        }
    }
}
