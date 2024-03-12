using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Inheritance.BirdFiles
{
    internal class Pelican : Bird
    {
        public float NeckLength { get; set; }

        public Pelican(string _name, int _age, float _weight, float _height, int _flightSpeed, float _neckLength)
        : base(_name, _age, _weight, _height, _flightSpeed)
        {
            NeckLength = _neckLength;
        }
    }
}
