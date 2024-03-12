using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Inheritance
{
    internal class Worm : Animal
    {
        public int NumberOfOffspring { get; set; }

        public Worm(string _name, int _age, float _weight, float _height, int _numberOfOffspring)
        : base(_name, _age, _weight, _height)
        {
            NumberOfOffspring = _numberOfOffspring;
        }

        public override string DoSound()
        {
            return $"The {GetType().Name} sound like this:\tSticky-Icky";
        }

        public override string Stats()
        {
            PropertyInfo[] properties = GetType().GetProperties();
            StringBuilder sb = new StringBuilder();
            sb.Append($"The {GetType().Name} got these attributes:\t");
            foreach (PropertyInfo property in properties)
            {
                sb.Append(property.Name + " ");
            }
            return sb.ToString();
        }
    }
}
