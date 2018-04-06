using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_longest_palindrome
{
    class Program
    {
        public static int GetLongestPalindrome(string n)
        {
            if (string.IsNullOrEmpty(n)) return 0;
            int res = 1;
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = 0; j < n.Length - i; j++)
                {
                    string a = string.Concat(n.Substring(i, n.Length - (j + i)).Reverse().Select(x => x));
                    string b = n.Substring(i, n.Length - (j + i));
                    if (a == b)
                    {
                        if (a.Length > res) res = a.Length;
                        j = n.Length;
                    }
                }
            }
            return res;
        }
        //public static string GetLongestPalindrome(string str) // change return type to int !!!!
        //{
        //    char[] reverseArray;
        //    string strReverse;
        //    List<string> pangrams = new List<string>();
        //    int i = str.Length - 1, j = str.Length - 1, k = 0, l = 0;

        //    if (str.Length > 0)
        //    {
        //        reverseArray = str.ToCharArray();
        //        Array.Reverse(reverseArray);
        //        strReverse = new string(reverseArray);
        //        do
        //        {
        //            if (i == str.Length - 1 && k == 0)
        //            {
        //                if (str[i] == strReverse[l])
        //                {
        //                    pangrams.Add(str[i].ToString());
        //                }
        //                --i;
        //                ++l;
        //            }
        //            else if (j == 0 && k == str.Length)
        //            {
        //                if (str[j] == strReverse[k])
        //                {
        //                    pangrams.Add(str[i].ToString());
        //                }
        //            }
        //            if (i > 0)
        //            {
        //                if (str.Substring(i, l) == strReverse.Substring(k, l))
        //                {
        //                    pangrams.Add(str.Substring(i, l));
        //                }
        //                --i;
        //                ++l;
        //            }
        //            else
        //            {
        //                if (i == k && j == l && str.Substring(i, j) == strReverse.Substring(k, j))
        //                {
        //                    pangrams.Add(str.Substring(i, j));
        //                }
        //                if (str.Substring(i, j + 1) == strReverse.Substring(k, j + 1))
        //                {
        //                    pangrams.Add(str.Substring(i, j + 1));
        //                }
        //                 --j;
        //                ++k;
        //            }
        //        } while (j >= 0);
        //        return pangrams.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);                
        //    }
        //    else
        //    {
        //        return "0"; // change to int !!!!
        //    }
        //}

        static void Main(string[] args)
        {
            Console.WriteLine(GetLongestPalindrome("zzbaabcd")); // 4
            Console.WriteLine(GetLongestPalindrome("12 21glg")); // 5
            Console.WriteLine(GetLongestPalindrome("abc0cba1")); // 7
            Console.WriteLine(GetLongestPalindrome("a")); // 1
            Console.WriteLine(GetLongestPalindrome("aab")); // 2
            Console.WriteLine(GetLongestPalindrome("abcde")); // 1
            Console.WriteLine(GetLongestPalindrome("baa")); // 2
            Console.WriteLine(GetLongestPalindrome("aa")); // 2
            Console.WriteLine(GetLongestPalindrome("   ")); // 3

            Console.ReadKey();
        }
    }
}
