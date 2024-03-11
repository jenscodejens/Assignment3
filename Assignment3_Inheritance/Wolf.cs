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
            return "Neigh *prffff*";
        }
    }
}
