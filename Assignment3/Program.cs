using System.Text;

namespace Assignment3
{
    internal class Program
    /*  Todo:
     *  Flytta menyn till egen metod utanför Main.
     *  Fixa listOfPersons.Count == 0 check direkt i för vissa funktioner, Delete, Change name
     *  Dölja om användare väljer att skriva något istället för använda piltangenter, suddas enbart ut för tillfället.
     *  
     *  Try Catch är definierad som uppgiften kräver men i och med min "överarbetade/testande)-lösning så ignoreras den.
     *
     *  Grov beskrivning av funktionaliteten
     *  ------------------------------------
     *  Användaren presenteras av en lista med val som styrs med piltanger (menykoden är modifierade utifrån en menylösning jag fann online).
     *  En lista består av objekt av klassen Person. När listan inte är tom väljer man sitt objket baserat på objektens index i listan. 
     *  Detta index sparas i activeObject och används vid namnbyte etc.
     *  Nya objekt skapas antingen genom user input alt. seeda in 3st objekt.
     *  Återstår saker att bena ut, de står kommenterade men det är dags att släppa detta och läsa in mer kunska,
     *  så detta får vara den slutliga koden tills jag finner tid och ny kunskap att komma tillbaka och förbättra.
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
                Console.WriteLine("<< Person Menu >>");
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
                    Console.WriteLine($"{(option == 7 ? color : "")} Exit program\u001b[0m");

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
                        default:
                            Utilities.ClearPreviousConsoleLine();
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
