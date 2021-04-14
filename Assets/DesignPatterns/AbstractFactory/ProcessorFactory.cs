using DesignPatterns.Common;

namespace DesignPatterns.AbstractFactory
{
    public class ProcessorFactory : IComputerPartFactory
    {
        public ComputerPart CreateComputerPart(string model)
        {
            return new Processor(model);
        }
    }
}
