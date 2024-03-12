using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            return $"The {GetType().Name} sound like this:\tNeigh *prffff*";
        }
        public override string Stats()
        {
            PropertyInfo[] properties = GetType().GetProperties();
            StringBuilder sb = new StringBuilder();
            sb.Append($"The {GetType().Name} got these attributes:\t");
            foreach (PropertyInfo property in properties)
            {
                sb.Append(property.Name + " ");
            }
            return sb.ToString();
        }
    }
}
