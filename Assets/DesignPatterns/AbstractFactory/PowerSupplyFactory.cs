using DesignPatterns.Common;

namespace DesignPatterns.AbstractFactory
{
    public class PowerSupplyFactory : IComputerPartFactory
    {
        public ComputerPart CreateComputerPart(string model)
        {
            return new PowerSupply(model);
        }
    }
}
