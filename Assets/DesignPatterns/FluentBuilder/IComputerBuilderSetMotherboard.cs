using DesignPatterns.Common;

namespace DesignPatterns.FluentBuilder
{
    public interface IComputerBuilderSetMotherboard
    {
        public IComputerBuilderSetProcessor SetMotherboard(Motherboard motherboard);
    }
}