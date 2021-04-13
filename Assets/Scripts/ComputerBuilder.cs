namespace DesignPattern.FluentBuilder
{
    public class ComputerBuilder : 
        IComputerBuilderSetMotherboard,
        IComputerBuilderSetProcessor,
        IComputerBuilderSetPowerSupply,
        IComputerBuilderAddGraphicCard
    {
        private readonly Computer _computer;

        private ComputerBuilder()
        {
            _computer = new Computer();
        }

        public static ComputerBuilder Create() => new ComputerBuilder();
    }
}

// TODO Operations order
// TODO RAM or GPU limited to Motherboard slot count