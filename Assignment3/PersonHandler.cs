using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml.Linq;


/*
 * 
 *  LÄS IN indexToUse OBJEKTET
 * 
 */
namespace Assignment3
{
    internal class PersonHandler
    {
        private static List<Person> ListOfPersons = new List<Person>();
        public static int indexToUse;
        public static Person activeObject = ListOfPersons[indexToUse];

        
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

        //    Console.WriteLine(format, "First name:", ListOfPersons[indexToUse].FName);
        //    Console.WriteLine(format, "Last name:", ListOfPersons[indexToUse].LName);
        //    Console.WriteLine(format, "Age:", ListOfPersons[indexToUse].Age);
        //    Console.WriteLine(format, "Height:", ListOfPersons[indexToUse].Height + " cm");
        //    Console.WriteLine(format, "Weigth:", ListOfPersons[indexToUse].Weight + " kg");
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

        //public void SetObject()
        //{   indexToUse = GetIndexToWorkWith();
        //    activeObject = ListOfPersons[indexToUse];
        //}
        public void GetIndexToWorkWith()
        {
            DisplayAllPersons();
            uint index = Utilities.GetUserInputUint("\nChoose index: ");
            indexToUse = (int)index;
            activeObject = ListOfPersons[indexToUse];
        }

        public void DeletePerson()
        {
            DisplayAllPersons();
            Console.WriteLine("Deleted: " + activeObject.FName + " " + activeObject.LName);
            ListOfPersons.Remove(activeObject);
            DisplayAllPersons();
        }
        //public void DeletePerson(int indexToUse)
        //{
        //    Console.WriteLine("Deleted: " + ListOfPersons[indexToUse].FName + " " + ListOfPersons[indexToUse].LName);
        //    ListOfPersons.RemoveAt(indexToUse);
        //    DisplayAllPersons();
        //}

        public void ChangeFirstName(int indexToUse)
        {
            string name = Utilities.GetUserInputString("\nNew firstname: ");
            Console.Write(ListOfPersons[indexToUse].FName);
            Console.WriteLine($" changed to {name}\n");
            ListOfPersons[indexToUse].FName = name;
            DisplayPersonDetail(indexToUse);
            Console.ReadLine();
        }

        public void ChangeLastName(int indexToUse)
        {
            string name = Utilities.GetUserInputString("\nNew lastname: ");
            Console.Write(ListOfPersons[indexToUse].LName);
            Console.WriteLine($" changed to {name}\n");
            ListOfPersons[indexToUse].LName = name;
            DisplayPersonDetail(indexToUse);
            Console.ReadLine();
        }
    }
}

