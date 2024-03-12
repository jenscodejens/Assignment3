using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Inheritance.BirdFiles
{
    internal class Flamingo : Bird
    {
        public string Color { get; set; }
        public Flamingo(string _name, int _age, float _weight, float _height, int _flightSpeed, string _color) : base(_name, _age, _weight, _height, _flightSpeed)
        {
            Color = _color;
        }
    }
}
