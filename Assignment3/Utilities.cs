using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Utilities
    {
        public static uint GetUserInputUint(string userInput)
        {

            do
            {
                string input = GetUserInputString(userInput);
                if (uint.TryParse(input, out uint returnUint))
                {
                    return returnUint;
                }
            } while (true);
        }

        public static string GetUserInputString(string userInput)
        {
            bool success = false;
            string userString;

            do
            {
                Console.Write($"{userInput}");
                userString = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(userString))
                {
                    Console.WriteLine($"You must enter a valid {userInput}");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return userString;
        }

    }
}
