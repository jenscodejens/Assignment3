using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Inheritance
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string _name, int _age, float _weight, float _height, string _habitat) 
        : base(_name, _age, _weight, _height, _habitat)
        {
        }

        public string Talk()
        {
            return "Hello there, I'm Wolfie";
        }
    }
}
