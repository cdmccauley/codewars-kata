using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csharp_validate_pin
{
    class Program
    {
        public static bool ValidatePin(string pin)
        {
            Regex invalidValues = new Regex(@"\D");
            string compareValue = invalidValues.Replace(pin, string.Empty);

            return ((pin.Length == 4 || pin.Length == 6) && pin == compareValue) ? true : false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePin("1234"));
            Console.WriteLine(ValidatePin("12345"));
            Console.WriteLine(ValidatePin("a234"));

            Console.ReadKey();
        }
    }
}
