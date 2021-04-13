namespace DesignPatterns.FluentBuilder
{
    public class Motherboard : ComputerPart
    {
        public int MemorySlots { get; }

        public Motherboard(string model, int memorySlots) : base(model)
        {
            MemorySlots = memorySlots;
        }

        public override string ToString()
        {
            return $"{base.ToString()} | {MemorySlots.ToString()} RAM Slots";
        }
    }
}
