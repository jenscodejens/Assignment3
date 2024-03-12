using Assignment3;
using System.Runtime.CompilerServices;
using System.Text;

namespace Assignment3
{
    internal class Program
    /*  Återstår mycket fixar
     *  Göra om så att inte flera funktioner kollar om den finns personer i listan och då seedar.
     *  
     *  Tänkte att jag ska ändra så att vid uppstart kommer man automatiskt in på CreateNewPerson.
     *  Utöver det logik att kolla att om en person tas bort så görs if (ListOfPersons.Count == 0).
     *  Skulle det hända så hänvisas man automatiskt även där till CreateNewPerson.
     *  
     *  Mycket som skall fixas men p.g.a. sjukdome fick jag lägga allt krut på att göra klart
     *  de andra uppgifterna.
     *
     *  Råkade ta bort all try/catch. Fixar detta snarast även det.
     *  Så i korthet är denna deluppgiften lite på is även om allt utom try/catch är fungerande men
     *  med brister.
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
                //PersonHandler.ListIsPopulated(); // Simulate the call for a CreatePerson at startup

                while (!isSelected)
                {
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine($"\n{(option == 1 ? color : "")} Show all persons\u001b[0m ");
                    Console.WriteLine($"{(option == 2 ? color : "")} Add person(mockups)\u001b[0m");
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
                    Console.ReadLine();
                }
                // Seeda in 3 personer
                else if (option == 2)
                {
                    Console.WriteLine();
                    handler.CreatePerson(45, "Frodo", "Baggins", 124, 48.5);
                    handler.CreatePerson(33, "Samwise", "Gamgee", 127, 53.6);
                    handler.CreatePerson(127, "Gimli", "Son of Gloin", 137, 81.53);
                    Console.WriteLine("3 mockup hobbits added");
                    Console.ReadLine();
                }
                // DisplayPersonDetails
                if (option == 3)
                {
                    handler.DisplayAllPersons();
                    var activeObject = handler.GetPersonIndex();
                    handler.DisplayPersonDetails(activeObject);
                    Console.ReadLine();
                }
                // ChangeFirstName
                if (option == 4)
                {
                    Console.WriteLine();
                    handler.DisplayAllPersons();
                    var activeObject = handler.GetPersonIndex();
                    handler.ChangeFirstName(activeObject);
                    Console.ReadLine();
                }
                // DeletePerson
                if (option == 5)
                {
                    Console.Clear();
                    handler.DisplayAllPersons();
                    var activeObject = handler.GetPersonIndex();
                    handler.DeletePerson(activeObject);
                    Console.ReadLine();
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
