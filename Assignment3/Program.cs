using Assignment3;
using System.Runtime.CompilerServices;
using System.Text;

namespace Assignment3
{
    internal class Program
    /*  Todo:
     *  Flytta menyn till egen metod utanför Main.
     *  
     *  Fixa listOfPersons.Count == 0 check direkt i DeletePerson innan index efterfrågas.
     *  
     *  Try Catch ignoreras för tillfället
     */
    {
        static void Main(string[] args)
        {
            PersonHandler handler = new PersonHandler();
            Utilities utilities = new Utilities();
            bool menuInput = true;
            do
            {
                Console.Title = "Assignment 4";
                Console.Clear();
                Console.OutputEncoding = Encoding.UTF8;
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Welcome to the wonders of Assignment 4");
                Console.ResetColor();
                Console.WriteLine("\nUse \u001b[32m⬆️\u001b[0mand \u001b[32m⬇️\u001b[0m and \u001b[32mEnter\u001b[32m");
                (int left, int top) = Console.GetCursorPosition();
                var option = 1;
                string color = "\u001b[32m";
                ConsoleKeyInfo key;
                bool isSelected = false;

                while (!isSelected)
                {
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine($"\n{(option == 1 ? color : "")} Show all persons\u001b[0m ");
                    Console.WriteLine($"{(option == 2 ? color : "")} Add 3 person seeds\u001b[0m");
                    Console.WriteLine($"{(option == 3 ? color : "")} Display person details\u001b[0m");
                    Console.WriteLine($"{(option == 4 ? color : "")} Change first name\u001b[0m");
                    Console.WriteLine($"{(option == 5 ? color : "")} Delete person\u001b[0m");
                    Console.WriteLine($"{(option == 6 ? color : "")} Add person\u001b[0m");
                    Console.WriteLine($"{(option == 7 ? color : "")} Exits program\u001b[0m");

                    key = Console.ReadKey(false);

                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            option = option == 1 ? 7 : option - 1;
                            break;

                        case ConsoleKey.DownArrow:
                            option = option == 7 ? 1 : option + 1;
                            break;

                        case ConsoleKey.Enter:
                            isSelected = true;
                            break;
                    }
                }

                if (option == 1)
                {
                    Console.WriteLine();
                    handler.DisplayAllPersons();
                }
                // Seeda in 3 personer
                else if (option == 2)
                {
                    Console.WriteLine();
                    handler.AddMockPersons();
                }
                // DisplayPersonDetails
                if (option == 3)
                {
                    Console.Clear();
                    handler.DisplayAllPersons();
                    var activeObject = handler.GetPersonIndex();
                    handler.DisplayPersonDetails(activeObject);
                    Console.ReadLine();
                }
                // ChangeFirstName
                if (option == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Change first name\n");
                    handler.DisplayAllPersons();
                    var activeObject = handler.GetPersonIndex();
                    handler.ChangeFirstName(activeObject);
                    Console.ReadLine();
                }
                // DeletePerson
                if (option == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Delete person\n");
                    handler.DisplayAllPersons();
                    var activeObject = handler.GetPersonIndex();
                    handler.DeletePerson(activeObject);
                }
                // CreatePerson
                if (option == 6)
                {
                    Console.Clear();
                    Person newPerson = utilities.GetInputForNewPerson();
                    handler.CreatePerson(newPerson.Age, newPerson.FName, newPerson.LName, newPerson.Height, newPerson.Weight);
                    handler.AddPersonToList(newPerson);
                    Console.ReadLine();
                }
                // Avsluta programmet
                else if (option == 7)
                {
                    menuInput = false;
                }
            } while (menuInput);
        }
    }
}
