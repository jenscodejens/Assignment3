using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment3
{
    // Klass som ärver från System.ApplicationException. Behövde lite custom error messages.
    internal class CustomExceptions : ApplicationException
    {
        public void LastNameException() 
        {
            Console.WriteLine($"Error: Last name must be longer than 3 letters.");
        }

        public void FirstNameException()
        {
            Console.WriteLine($"Error: First name must be longer than 2 letters.");
        }
    }
}
