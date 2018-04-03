using System;
using System.Text;
using System.Text.RegularExpressions;

namespace csharp_your_order_please
{
    class Program
    {
        public static String order(String words)
        {
            string[] orderedWords = new string[words.Split().Length];
            Regex indexNum = new Regex("[0-9*]");
            StringBuilder returnString = new StringBuilder();

            if (words == "")
                return "";
            else
            {
                foreach (string word in words.Split())
                    orderedWords[(int.Parse(indexNum.Match(word).ToString()) - 1)] = word;

                foreach (string word in orderedWords)
                    returnString.Append(word + " ");

                return returnString.ToString().TrimEnd(' ');
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(order("is2 Thi1s T4est 3a"));

            Console.ReadKey();
        }
    }
}
