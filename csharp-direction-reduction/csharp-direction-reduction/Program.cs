using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_direction_reduction
{
    class Program
    {
        public static string[] dirReduc(String[] arr)
        {
            // declarations
            Dictionary<String, String> cardinalOpposites = new Dictionary<String, String>();
            List<String> directions = new List<String>();
            bool skippedLast = false;

            // pair opposites
            cardinalOpposites.Add("NORTH", "SOUTH");
            cardinalOpposites.Add("SOUTH", "NORTH");
            cardinalOpposites.Add("EAST", "WEST");
            cardinalOpposites.Add("WEST", "EAST");

            // if next value is opposite don't add it to the list
            // if a value was added check for conflict with the value before it
            for (int i = 0; i < arr.Length; ++i)
            {
                if (!skippedLast)
                {
                    if (i < arr.Length - 1)
                    {
                        if (!arr[i].Equals(cardinalOpposites[arr[i + 1]]))
                            directions.Add(arr[i]);
                        else
                            skippedLast = true;
                    }
                    else
                        directions.Add(arr[i]);
                    if (directions.Count > 1)
                        if (directions.ElementAt(directions.Count - 1)
                            .Equals(cardinalOpposites[directions.ElementAt(directions.Count - 2)]))
                            directions.RemoveRange(directions.Count - 2, 2);
                }
                else
                    skippedLast = false;
            }

            return directions.ToArray<string>();
        }

        static void Main(string[] args)
        {
            string[] resultSet;

            resultSet = dirReduc(new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" }); // west
            foreach (string result in resultSet)
                Console.Write(result + ",");

            Console.WriteLine();

            resultSet = dirReduc(new string[] { "NORTH", "WEST", "SOUTH", "EAST" }); // same
            foreach (string result in resultSet)
                Console.Write(result + ",");

            Console.WriteLine();

            resultSet = dirReduc(new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH" }); // nothing
            foreach (string result in resultSet)
                Console.Write(result + ",");

            Console.ReadKey();
        }
    }
}
