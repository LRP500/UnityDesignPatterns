namespace DesignPatterns.FluentBuilder
{
    public interface IComputerBuilderSetMotherboard
    {
        public IComputerBuilderSetProcessor SetMotherboard(Motherboard motherboard);
    }
}