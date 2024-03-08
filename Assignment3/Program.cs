using Assignment3;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PersonHandler handler = new PersonHandler();
            handler.CreatePerson(33, "Samwise", "Gamgee", 127, 53.17 );
            handler.CreatePerson(45, "Frodo", "Baggins", 124, 48.53);
            Console.WriteLine();
            handler.GetIndexToWorkWith();
            handler.DeletePerson();
            Console.ReadLine();
        }
    }
}


//try
//{
//    Person p1 = new Person(45, "Tina", "Jonsson", 182, 69.3);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{   
//    Console.ResetColor();
//    Console.ReadLine();
//    // Call the fictional MainMenu-method
//}
//Person p = new Person(45, "Frodo", "Baggins", 124, 48.53);
//PersonHandler handler = new PersonHandler();
//handler.SetAge(p, 19);





