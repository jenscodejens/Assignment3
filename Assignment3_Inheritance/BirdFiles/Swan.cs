using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Inheritance.BirdFiles
{
    internal class Swan : Bird
    {
        public  bool BelongsToQueen { get; set; }

        public Swan(string _name, int _age, float _weight, float _height, int _flightSpeed, bool _belongsToQueen) : base(_name, _age, _weight, _height, _flightSpeed)
        {
            BelongsToQueen = _belongsToQueen;
        }
    }
}
