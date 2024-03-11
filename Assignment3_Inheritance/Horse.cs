using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Inheritance
{
    internal class Horse : Animal
    {
        public string  CoatColor { get; set; }

        public Horse(string _name, int _age, float _weight, float _height, string _coatColor)
        : base(_name, _age, _weight, _height)
        {
            CoatColor = _coatColor;
        }

        public override string DoSound()
        {
            return "Neigh *prffff*";
        }
    }
}
