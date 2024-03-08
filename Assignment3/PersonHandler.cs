using System.Linq;
using System.Collections.Generic;


/*
 * 
 *  LÄS IN indexToUse OBJEKTET
 * 
 */
namespace Assignment3
{
    internal class PersonHandler
    {
        private int indexToUse;
        private Person activeObject = Person.ReferenceEquals

        private List<Person> ListOfPersons = new List<Person>();
        public void CreatePerson(uint _age, string _fName, string _lName, double _height, double _weight)
        {
            ListOfPersons.Add(new Person(_age, _fName, _lName, _height, _weight));
        }

        public void SetAge(Person person, uint age)
        {
            person.Age = age;
        }

        //public void DisplayPersonDetail(int indexToUse)
        //{
        //    const string format = "{0,-12} {1}";

        //    Console.WriteLine(format, "First name:", person.FName);
        //    Console.WriteLine(format, "Last name:", person.LName);
        //    Console.WriteLine(format, "Age:", person.Age);
        //    Console.WriteLine(format, "Height:", person.Height + " cm");
        //    Console.WriteLine(format, "Weigth:", person.Weight + " kg");
        //}

        public void DisplayAllPersons()
        {
            for (int index = 0; index < ListOfPersons.Count; index++)
            {
                var person = ListOfPersons[index];
                Console.Write(index);
                Console.Write($": {person.FName} {person.LName}\n");
            }
        }

        public int GetIndexToWorkWith()
        {
            DisplayAllPersons();
            uint index = Utilities.GetUserInputUint("\nChoose index: ");
            return indexToUse = (int)index;
            
        }
        public void DeletePerson()
        {
            Console.WriteLine(indexToUse);
            //Console.WriteLine("Delete person by index: ");
            //uint index = Utilities.GetUserInputString("Delete person by index:  ");
            //ListOfPersons.RemoveAt(index); // Efter fiktiv user input "1"
            //DisplayAllPersons();
            //Console.ReadLine();
        }

        public void ChangeFirstName(int indexToUse)
        {
            string name = Utilities.GetUserInputString("\nNew firstname: ");
            
            //Console.Write("{0} changed to: {1}", ListOfPersons[indexToUse].FName {name});
            //Console.Write(ListOfPersons[indexToUse].FName + " changed to: {0}", {name};
            //Console.Write(ListOfPersons[indexToUse].FName = name);
            ListOfPersons[indexToUse].FName = name;
            // Console.WriteLine("Person details - {0} {1}", person1, person2)
            //Console.WriteLine($"Name changed to: {name}");
            //ListOfPersons[indexToUse].FName = name;
            //DisplayPersonDetail();
            Console.ReadLine();
        }
    }
}

