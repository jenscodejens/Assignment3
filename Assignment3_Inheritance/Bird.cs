using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Inheritance
{
    internal class Bird : Animal
    {
        public int FlightSpeed { get; set; }

        public Bird(string _name, int _age, float _weight, float _height, int _flightSpeed)
        : base(_name, _age, _weight, _height)
        {
            FlightSpeed = _flightSpeed;         
        }

        public override string DoSound()
        {
            return "Chirp chirp";
        }
        public override string ToString() => string.Format("{0,-10} {1}", "Bird", DoSound());
    }
}
