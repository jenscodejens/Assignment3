/*
 * 
 *  Fixa bool från DisplayAll 
 * 
 */
namespace Assignment3
{
    internal class PersonHandler
    {
        private static List<Person> ListOfPersons = new List<Person>();

        //public int? indexToUse;
        //public static Person? activeObject = null;
        //public static Person? person = null;

        public static bool ListIsPopulated()
        {
            if (ListOfPersons.Count == 0)
            {
                // Fiktiva personer istället för CreatePerson()
                Console.WriteLine("List is empty. Adding mockup list");
                Console.ReadLine();             
            }
            return true;
        }


        public void CreatePerson(uint _age, string _fName, string _lName, double _height, double _weight)
        {
            ListOfPersons.Add(new Person(_age, _fName, _lName, _height, _weight));
        }

        public void AddMockPersons()
        {
            CreatePerson(45, "Frodo", "Baggins", 124, 48.53);
            CreatePerson(139, "Gimli", "son of Gloin", 137, 99.8);
        }

        public void SetAge(Person person, uint age)
        {
            person.Age = age;
        }

        public void DisplayPersonDetails(Person activeObject)
        {
            Person person = activeObject;
            const string format = "{0,-12} {1}";

            Console.WriteLine(format, "First name:", person.FName);
            Console.WriteLine(format, "Last name:", person.LName);
            Console.WriteLine(format, "Age:", person.Age);
            Console.WriteLine(format, "Height:", person.Height + " cm");
            Console.WriteLine(format, "Weigth:", person.Weight + " kg");
        }

        public void DisplayAllPersons()
        {
            if (ListOfPersons.Count >= 1)
            {
                for (int index = 0; index < ListOfPersons.Count; index++)
                {
                    var person = ListOfPersons[index];
                    Console.Write(index);
                    Console.Write($": {person.FName} {person.LName}\n");
                }
            }
            else
            {
                Console.WriteLine(">> No persons added yet <<\n");
            }

        }

        public (bool listExist, Person person) GetPersonIndex()
        {
            if (ListOfPersons.Count == 0)
            {
                Console.WriteLine(">> No persons added yet <<");
                return (false, null!);
            }

            uint index = Utilities.GetUserInputUint("\nChoose index: ");
            int indexToUse = (int)index; // sätt vilket index

            if (indexToUse >= 0 && indexToUse < ListOfPersons.Count)
            {
                return (true, ListOfPersons[indexToUse]);
            }
            else
            {
                Console.WriteLine("Invalid index. Please choose a valid index.");
                return (false, null!);
            }
        }


        public void ChangeFirstName(Person person)
        {
            if (ListOfPersons.Count == 0)
            {
                Console.WriteLine(">> No persons added yet <<");
            }
            else
            {
                if (person != null)
                {
                    string newName = Utilities.GetUserInputString("\nNew firstname: ");
                    Console.WriteLine($"{person.FName} changed to {newName}\n");
                    person.FName = newName;
                    DisplayPersonDetails(person);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("No person selected. Please choose a valid index.");
                }
            }
        }
        public void DeletePerson(Person person)
        {
            if (ListOfPersons.Count == 0)
            {
                Console.WriteLine(">> No persons added yet <<");
            }
            else
            {
                //uint deletePerson = Utilities.GetUserInputUint("\nDelete: ");
                Console.WriteLine("Deleted: " + person.FName + " " + person.LName);
                ListOfPersons.Remove(person);
                Console.ReadLine();

            }
        }
    }
}


//public void ChangeFirstName(Person activeObject)
//{
//    Person person = activeObject;
//    if (person != null)
//    {
//        string newName = Utilities.GetUserInputString("\nNew firstname: ");
//        Console.WriteLine($"{person.FName} changed to {newName}\n");
//        person.FName = newName;
//        DisplayPersonDetails(person);
//        Console.ReadLine();
//    }
//    else
//    {
//        Console.WriteLine("No person selected. Please choose a valid index.");
//    }
//}



//public void ChangeFirstName()
//{
//    Person person = GetPersonIndex();
//    if (person != null)
//    {
//        string newName = Utilities.GetUserInputString("\nNew firstname: ");
//        Console.WriteLine($"{person.FName} changed to {newName}\n");
//        person.FName = newName;
//        DisplayPersonDetails();
//        Console.ReadLine();
//    }
//    else
//    {
//        Console.WriteLine("No person selected. Please choose a valid index.");
//    }
//}


//public void DeletePerson(Person person)
//{
//    var person = activeObject;
//    DisplayAllPersons();
//    Console.WriteLine("Deleted: " + person!.FName + " " + person.LName);
//    ListOfPersons.Remove(person);
//    DisplayAllPersons();
//}
//public void DeletePerson(int indexToUse)
//{
//    Console.WriteLine("Deleted: " + ListOfPersons[indexToUse].FName + " " + ListOfPersons[indexToUse].LName);
//    ListOfPersons.RemoveAt(indexToUse);
//    DisplayAllPersons();
//}
//public void ChangeLastName(int indexToUse)
//{
//    string name = Utilities.GetUserInputString("\nNew lastname: ");
//    Console.Write(ListOfPersons[indexToUse].LName);
//    Console.WriteLine($" changed to {name}\n");
//    ListOfPersons[indexToUse].LName = name;
//    DisplayPersonDetails();
//    Console.ReadLine();
//}

//public void SetObject()
//{   indexToUse = GetIndexToWorkWith();
//    activeObject = ListOfPersons[indexToUse];
//}

//public Person GetIndexToWorkWith()
//{
//    if (ListOfPersons.Count >= 1)
//    {
//        uint index = Utilities.GetUserInputUint("\nChoose index: ");
//        indexToUse = (int)index;
//        return activeObject = ListOfPersons[indexToUse];
//    }
//    else
//    {
//        Console.WriteLine(">> No persons added yet <<");
//    }
//}


