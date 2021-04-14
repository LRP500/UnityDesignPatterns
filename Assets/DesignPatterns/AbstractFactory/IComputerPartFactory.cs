using DesignPatterns.Common;

namespace DesignPatterns.AbstractFactory
{
    public interface IComputerPartFactory
    {
        public abstract ComputerPart CreateComputerPart(string model);
    }    
}