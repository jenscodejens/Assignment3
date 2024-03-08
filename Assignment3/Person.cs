using System.Xml.Linq;

namespace Assignment3
{
    internal class Person
    {

        private uint _age = 0;
        private string _fName = String.Empty;
        private string _lName = String.Empty;
        private double _height = 0;
        private double _weight = 0;

        public uint Age
        {
            get { return _age; }
            set { _age = value < 1 ? 1 : value; }
        }

        public string FName
        {
            get { return _fName; }
            set
            {
                if (value is null)
                {
                    throw new System.ArgumentNullException("Person: First name cannot be null");
                }
                _fName = (value.Length >= 2 && value.Length <= 10) ? value : "[Missing data]";
            }
        }

        public string LName
        {
            get { return _lName; }
            set {
                if (value is null)
                {
                    throw new System.ArgumentNullException("Person: Last name cannot be null");
                }
                _lName = (value.Length >= 3 && value.Length <= 15) ? value : "[Missing data]"; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = Math.Round(value, 2); }
        }

        public double Weight
        { 
            get { return _weight; }
            set { _weight = Math.Round(value, 1); }
        }

        public Person(uint _age, string _fName, string _lName, double _height, double _weight)
        {
            Age = _age;
            FName = _fName;
            LName = _lName;
            Height = _height;
            Weight = _weight;
        }

        public override string ToString()
        {
            return $"{Age} {FName} {LName} {Height} {Weight}";
        }
    }
}
