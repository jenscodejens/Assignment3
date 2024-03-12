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

        /* Och kan egentligen vara exakt så som jag har i övriga djur klasser, Animal som objekt kan ju inte instansieras ändå.
         * Men antar ni vill belysa overrides användningsområde.
         * 
         * Eller så kan man göra en return för Stats() i Animal som returnerar name age weight height
         * 
         * och sedan läsa in den return i childklasserna som animalStats = base.Stats();
         * return base.Stats += <den extra property>
         *
         * Gjorde som jag gjorde men ger lite alternativ.
         */
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


