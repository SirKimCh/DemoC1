using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Demo2.Validation
{
    internal class MyLib
    {
        public static bool IsListEmpty<T>(List<T> values, string messageIfEmpty)
        {
            if (values.Count() == 0)
            {
                Console.WriteLine(messageIfEmpty);
                return true;
            }
            return false;
        }

        public static int GetIntInput(string messageError,int min,int max)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result) && result >= min && result <= max)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine(messageError);
                    Console.Write("Enter again: ");
                }
            }
        }

        public static string GetStringInput(string messageError)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && Regex.IsMatch(input, @"^\w+\s+\w+"))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine(messageError);
                    Console.Write("Enter again: ");
                }
            }
        }
    }
}

