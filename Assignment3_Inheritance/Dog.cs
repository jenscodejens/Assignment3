using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Inheritance
{
    internal class Dog : Animal
    {
        public string TurColor { get; set; }
        
        public Dog(string _name, int _age, float _weight, float _height, string _turColor)
        : base(_name, _age, _weight, _height)
        {
            TurColor = _turColor;
        }

        public override string DoSound()
        {
            return $"The {GetType().Name} sound like this:\tBark bark!";
        }

        public override string Stats()
        {
            PropertyInfo[] properties = GetType().GetProperties();
            StringBuilder sb = new StringBuilder();
            sb.Append($"The {GetType().Name} these attributes:\t");
            foreach (PropertyInfo property in properties)
            {
                sb.Append($"{property.Name}: {property.GetValue(this)}\n");
            }
            return sb.ToString();
        }
    }
}
