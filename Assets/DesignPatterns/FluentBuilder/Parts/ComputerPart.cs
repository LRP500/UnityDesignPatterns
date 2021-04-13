namespace DesignPatterns.FluentBuilder
{
    public class ComputerPart
    {
        public string Model { get; }

        protected ComputerPart(string model)
        {
            Model = model;
        }

        public override string ToString() => Model;
    }
}    
