using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Inheritance
{
    internal class Dog : Animal
    {
        public string FurColor { get; set; }
        
        public Dog(string _name, int _age, float _weight, float _height, string _furColor)
        : base(_name, _age, _weight, _height)
        {
            FurColor = _furColor;
        }

        public override string DoSound()
        {
            return "Bark bark!";
        }
    }
}
