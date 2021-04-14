namespace DesignPatterns.Common
{
    public abstract class ComputerPart
    {
        public string Model { get; }
        public float Price { get; private set; }

        protected ComputerPart(string model)
        {
            Model = model;
        }

        protected ComputerPart(string model, float price) : this(model)
        {
            Price = price;
        }
        
        public override string ToString() => Model;
    }
}