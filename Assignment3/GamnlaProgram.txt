using Assignment3;
using System.Runtime.CompilerServices;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MainMenu();

            static void MainMenu()
            {
                PersonHandler handler = new PersonHandler();
                //Person? activePerson = null;
                char menuInput = '\0';
                do
                {
                    Console.WriteLine(StandardMessages.TopMenuText);
                    Console.Write("Make your selection: ");
                    if (char.TryParse(Console.ReadLine()!.ToUpper(), out menuInput))
                    {
                        switch (menuInput)
                        {
                            case '1':
                                handler.DisplayAllPersons();
                                break;
                            case '2':
                                handler.CreatePerson(45, "Frodo", "Baggins", 124, 48.53);
                                handler.CreatePerson(45, "Sam", "Baggins", 124, 48.53);
                                handler.CreatePerson(45, "Gimli", "Baggins", 124, 48.53);
                                Console.WriteLine("3 mockups added");
                                Console.ReadLine();
                                break;
                            case '3':
                                handler.DisplayAllPersons();
                                handler.DisplayPersonDetails(handler.GetPersonIndex());
                                Console.ReadLine();
                                break;
                            case '4':
                                //Person activePerson = handler.GetPersonIndex();
                                //handler.ChangeFirstName(activePerson);
                                handler.DisplayAllPersons();
                                handler.ChangeFirstName(handler.GetPersonIndex());
                                Console.ReadLine();
                                break;
                            case 'H':

                                break;
                            case '0':

                                break;
                            default:
                                StandardMessages.ErroneousInputMessage();
                                break;
                        }
                    }
                } while (menuInput != '0');
            }
        }
    }
}
            
//            static void TicketSubMenu()
//            {

//                char menuInput = '\0';
//                do
//                {
//                    StandardMessages.TicketSubMenuMessage();
//                    if (char.TryParse(Console.ReadLine()!.ToUpper(), out menuInput))
//                    {
//                        switch (menuInput)
//                        {
//                            case '1':
//                                break;
//                            case '2':

//                                break;
//                            case '3':

//                                break;
//                            case 'H':

//                                break;
//                            default:
//                                StandardMessages.ErroneousInputMessage();
//                                break;
//                        }
//                    }
//                } while (menuInput != '3');
//            }
//        }
//    }
//}
//        {

//            PersonHandler handler = new PersonHandler();
//            handler.CreatePerson(33, "Samwise", "Gamgee", 127, 53.17 );
//            handler.CreatePerson(45, "Frodo", "Baggins", 124, 48.53);
//            handler.CreatePerson(139, "Gimli", "son of Gloin", 137, 99.8);
//            handler.DisplayAllPersons();
//            Person activePerson = handler.GetPersonIndex();
//            Console.WriteLine();
//            Console.ReadLine();
//            handler.ChangeFirstName(activePerson);
//            Console.ReadLine();
//            Console.ReadLine();


//            //handler.DisplayAllPersons();
//            //handler.CreatePerson(19, "Anna", "Olsson", 137, 99.8);
//            //handler.DeletePerson();
//            //handler.DisplayAllPersons();
//        }
//    }
//}


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





