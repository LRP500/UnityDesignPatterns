using DesignPatterns.Common;

namespace DesignPatterns.FluentBuilder
{
    public interface IComputerBuilderSetPowerSupply
    {
        public ComputerBuilder SetPowerSupply(PowerSupply powerSupply);
    }
}
