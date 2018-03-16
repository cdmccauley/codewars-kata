using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_duplicate_encoder
{
    class Program
    {
        static string DuplicateEncode(string word)
        {
            List<char> uniqueChar = new List<char>();
            StringBuilder replacement = new StringBuilder();

            var uniqueCharQuery =
                from characters in word.ToLower()
                group characters by characters into charGroup
                where charGroup.Count() == 1
                select charGroup.Key;

            foreach (char character in uniqueCharQuery)
                uniqueChar.Add(character);

            foreach (char character in word.ToLower())
                if (uniqueChar.Contains(character))
                    replacement.Append('(');
                else
                    replacement.Append(')');

            return replacement.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateEncode("Success"));

            Console.ReadKey();
        }
    }
}
