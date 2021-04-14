using DesignPatterns.Common;

namespace DesignPatterns.FluentBuilder
{
    public interface IComputerBuilderSetProcessor
    {
        public IComputerBuilderSetPowerSupply SetProcessor(Processor processor);
    }
}