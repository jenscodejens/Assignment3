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

        public static double GetUserInputDouble(string userInput)
        {
            do
            {
                string input = GetUserInputString(userInput);
                if (double.TryParse(input, out double returnUint))
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
                    ClearPreviousConsoleLine();
                    Console.WriteLine($"You must enter a valid {userInput}");
                    ClearPreviousConsoleLine();
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return userString;
        }

        public Person GetInputForNewPerson()
        {
            Console.WriteLine("Create new person");
            string fname = GetUserInputString("First name: ");
            string lname = GetUserInputString("Last name: ");
            uint age = GetUserInputUint("Age: ");
            double height = GetUserInputDouble("Height: ");
            double weight = GetUserInputDouble("Weight: ");

            var person = new Person(age, fname, lname, height, weight);
            return person;

        }
        public static void ClearPreviousConsoleLine()
        {
            Console.CursorTop--;
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
