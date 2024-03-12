namespace Assignment3
{
    // Klass som ärver från System.ApplicationException. Behövde lite custom error messages.
    internal class CustomExceptions : ApplicationException
    {
        public void LastNameException()
        {
            Console.WriteLine($"Error: First name must be at least 3 letters and no more than than 15 letters.");
            Console.ReadLine();
        }

        public void FirstNameException()
        {
            Console.WriteLine($"Error: First name must be at least 2 letters and no more than than 10 letters.");
            Console.ReadLine();
        }
    }
}
