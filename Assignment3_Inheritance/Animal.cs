using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Inheritance
{
    internal abstract class Animal
    {
        //private string _name;
        //private int _age;
        //private float _weight;
        //private float _height;

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
    }
}
