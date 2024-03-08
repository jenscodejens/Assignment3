using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class StandardMessages
    {

        public const string TopMenuText = "Persons\n\n" +
                                  "[1]  Show all persons\n" +
                                  "[2]  Add person\n" +
                                  "[3]  Display person details\n" +
                                  "[4]  Change first name\n" +
                                  "[0]  Exits the program";

        public const string TicketSubMenu = "[1]  Ticket for one person\n" +
                                            "[2]  Tickets for more than one person\n" +
                                            "[3]  Back to previous menue\n";

        public static void ErroneousInputMessage()
        {
            Console.Write("Not a valid choice");
            Console.ReadLine();
        }

        public static void TicketSubMenuMessage()
        {
            Console.Clear();
            Console.WriteLine($"{TicketSubMenu}");
        }
    }
}
