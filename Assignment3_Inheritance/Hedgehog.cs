using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Inheritance
{
    internal class Hedgehog : Animal
    {
        public int NumberOfSpines { get; set; }

        public Hedgehog(string _name, int _age, float _weight, float _height, int _numberOfSpines)
        : base(_name, _age, _weight, _height)
        {
            NumberOfSpines = _numberOfSpines;
        }

        public override string DoSound()
        {
            return "Sniff.. sniff";
        }
    }
}
