using System.Xml.Linq;

namespace Assignment3
{
    internal class PersonHandler
    {
        private static List<Person> ListOfPersons = new List<Person>();

        /*public static void ListIsPopulated()
        {
            if (ListOfPersons.Count == 0)
            {
                // endast påbörjad förändring
                Console.WriteLine("List is empty. Adding mockup person");
                Person person = new Person(45, "Frodo", "Baggins", 124, 48.53);
                ListOfPersons.Add(person);
                Console.ReadLine();
            }
        }*/

        public Person CreatePerson(uint _age, string _fName, string _lName, double _height, double _weight)
        {
            Person person = new Person(_age, _fName, _lName, _height, _weight);
            return person;
        }

        public void AddPersonToList(Person person)
        {
            ListOfPersons.Add(person);
        }

        public void AddMockPersons()
        {
            ListOfPersons.Add(new Person(139, "Gimli", "son of Gloin", 137, 99.8));
            ListOfPersons.Add(new Person(139, "Legolas", "Fjant", 188, 80.8));
            ListOfPersons.Add(new Person(139, "Sauron", "Badass", 345, 200.3));
            Console.WriteLine("3 persons added.");
            Console.ReadLine();
        }

        public void SetAge(Person person, uint age)
        {
            person.Age = age;
        }

        public void DisplayPersonDetails(Person activeObject)
        {
            Person person = activeObject;
            const string format = "{0,-12} {1}";
            Console.WriteLine();
            Console.WriteLine(format, "First name:", person.FName);
            Console.WriteLine(format, "Last name:", person.LName);
            Console.WriteLine(format, "Age:", person.Age);
            Console.WriteLine(format, "Height:", person.Height + " cm");
            Console.WriteLine(format, "Weigth:", person.Weight + " kg");
        }

        public void DisplayAllPersons()
        {
            for (int index = 0; index < ListOfPersons.Count; index++)
            {
                var person = ListOfPersons[index];
                Console.Write(index);
                Console.Write($": {person.FName} {person.LName}\n");
            }
            Console.ReadLine();
        }

        public Person GetPersonIndex()
        {
            int indexToUse;
            bool success = false;
            do
            {
                uint index = Utilities.GetUserInputUint("Choose index: ");
                indexToUse = (int)index; //konvertera uint till list-index som baseras på int
                if (indexToUse >= 0 && indexToUse < ListOfPersons.Count)
                {
                    success = true;
                }
                else
                {
                    Utilities.ClearPreviousConsoleLine();
                    StandardMessages.InvalidIndex();
                    Console.ReadLine();
                }
            }
            while (!success);

            return ListOfPersons[indexToUse];
        }

        public void ChangeFirstName(Person person)
        {
            if (person != null)
            {
                string newName = Utilities.GetUserInputString("\nNew firstname: ");
                Console.Clear();
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

        public void DeletePerson(Person person)
        {
            Console.WriteLine("Deleted: " + person.FName + " " + person.LName);
            ListOfPersons.Remove(person);

            // Inte världens snyggaste lösning.. men om man tar bort så ingen person återstår skall en ny skapas.
            // Problem dock att den i program redan frågar om index, check om listOfPersons.Count == 0 måste in redan där.
            if (ListOfPersons.Count == 0) 
            {
                Console.WriteLine("List is now empty lets add a person.");
                Console.ReadLine();
                Console.Clear();
                PersonHandler handler = new PersonHandler();
                Utilities utilities = new Utilities();
                Person newPerson = utilities.GetInputForNewPerson();
                handler.CreatePerson(newPerson.Age, newPerson.FName, newPerson.LName, newPerson.Height, newPerson.Weight);
                handler.AddPersonToList(newPerson);
            }
            else
            {
                Console.WriteLine("Deleted: " + person.FName + " " + person.LName);
                ListOfPersons.Remove(person);
            }
            Console.ReadLine();
        }
    }
}

/*public Person GetPersonIndex()
{
    ListIsPopulated();
    uint index = Utilities.GetUserInputUint("\nChoose index: ");
    int indexToUse = (int)index; // sätt vilket index

    if (indexToUse >= 0 && indexToUse < ListOfPersons.Count)
    {
        return ListOfPersons[indexToUse];
    }
    else
    {
        StandardMessages.InvalidIndex();
        return null!;
    }
}*/


