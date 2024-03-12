using System.Reflection;
using System.Text;

namespace Assignment3_Inheritance
{
    internal class Wolf : Animal
    {
        public string Habitat { get; set; }

        public Wolf(string _name, int _age, float _weight, float _height, string _habitat)
        : base(_name, _age, _weight, _height)
        {
            Habitat = _habitat;
        }

        public override string DoSound()
        {
            return $"The {GetType().Name} sound like this:\tHooooowl";
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
