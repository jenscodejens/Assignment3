namespace Assignment3_ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UserError> listOfErrors = new List<UserError>();

            listOfErrors.Add(new NumericInputError());
            listOfErrors.Add(new TextInputError());
            listOfErrors.Add(new DayInputError());
            listOfErrors.Add(new MusicGenreInputError());
            listOfErrors.Add(new LoginCredentialInputError());

            foreach (var error in listOfErrors)
            {
                Console.WriteLine(error);
            }
            Console.ReadLine();
        }
    }
}

