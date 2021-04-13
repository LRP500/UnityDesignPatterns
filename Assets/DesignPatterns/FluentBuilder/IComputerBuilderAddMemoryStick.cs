using System.Collections.Generic;

namespace DesignPatterns.FluentBuilder
{
    public interface IComputerBuilderAddMemoryStick
    {
        public ComputerBuilder AddMemoryStick(MemoryStick memoryStick);
        public ComputerBuilder AddMemorySticks(MemoryStick memoryStick, int count);
        public ComputerBuilder AddMemorySticks(IEnumerable<MemoryStick> memorySticks);
        public ComputerBuilder AddMemorySticks(params MemoryStick[] memorySticks);
    }
}