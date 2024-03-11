using System;
using System.Collections.Generic;
using System.Linq;
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
            return "Sticky-Icky";
        }
    }
}
