using Assignment3;
using System.Runtime.CompilerServices;
using System.Text;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonHandler handler = new PersonHandler();
            //Person? activePerson = null;
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
                    Console.WriteLine($"{(option == 2 ? color : "")} Add person(mockups)\u001b[0m");
                    Console.WriteLine($"{(option == 3 ? color : "")} Display person details\u001b[0m");
                    Console.WriteLine($"{(option == 4 ? color : "")} Change first name\u001b[0m");
                    Console.WriteLine($"{(option == 5 ? color : "")} Delete person\u001b[0m");
                    Console.WriteLine($"{(option == 6 ? color : "")} Exits program\u001b[0m");

                    key = Console.ReadKey(false);

                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            option = option == 1 ? 6 : option - 1;
                            break;

                        case ConsoleKey.DownArrow:
                            option = option == 6 ? 1 : option + 1;
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
                    Console.ReadLine();
                }
                else if (option == 2)
                {
                    Console.WriteLine();
                    handler.CreatePerson(45, "Frodo", "Baggins", 124, 48.53);
                    handler.CreatePerson(33, "Samwise", "Gamgee", 127, 53.17);
                    handler.CreatePerson(127, "Gimli", "Son of Gloin", 137, 81.53);
                    Console.WriteLine("3 mockup hobbits added");
                    Console.ReadLine();
                }
                if (option == 3)
                {
                    Console.WriteLine();
                    handler.DisplayAllPersons();
                    var activeObject = handler.GetPersonIndex();

                    if (activeObject.listExist)
                    {
                        handler.DisplayPersonDetails(activeObject.person);
                    }
                    else
                    {
                        Console.WriteLine(">> No persons added yet <<\"");
                    }
                    Console.ReadLine();
                }
                if (option == 4)
                {
                    Console.WriteLine();
                    handler.DisplayAllPersons();
                    var activeObject = handler.GetPersonIndex();

                    if (activeObject.listExist)
                    {
                        handler.ChangeFirstName(activeObject.person);
                    }
                    else
                    {
                        Console.WriteLine(">> No persons added yet <<\"");
                    }
                    Console.ReadLine();
                }
                if (option == 5)
                {   Console.Clear();
                    handler.DisplayAllPersons();
                    var activeObject = handler.GetPersonIndex();

                    if (activeObject.listExist)
                    {
                        handler.DeletePerson(activeObject.person);
                    }
                    else
                    {
                        Console.WriteLine(">> No persons added yet <<\"");
                    }
                    Console.ReadLine();
                }

                else if (option == 6)
                {
                    menuInput = false;
                }

            } while (menuInput);
        }
    }
}