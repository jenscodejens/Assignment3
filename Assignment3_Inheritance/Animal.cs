using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment3_Inheritance
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public float Age { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public Animal(string _name, int _age, float _weight, float _height)
        {
            Name = _name;
            Age = _age;
            Weight = _weight;
            Height = _height;
        }

        public abstract string DoSound();

        // Nyfiken pros/cons mot en vanlig overloadad -this metod i respektive child?
        public virtual string Stats()
        {
            string result = string.Empty;
            return result;
        }

        public override string ToString()
        {
            return $"{GetType().Name}";
        }
    }
}


