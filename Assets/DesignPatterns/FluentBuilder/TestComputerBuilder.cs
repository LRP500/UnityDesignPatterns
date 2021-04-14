using DesignPatterns.Common;
using UnityEngine;

namespace DesignPatterns.FluentBuilder
{
    public class TestComputerBuilder : MonoBehaviour
    {
        private void Start()
        {
            ComputerBuilder.Create()
                .SetMotherboard(new Motherboard("Asus ROG STRIX B550", 4))
                .SetProcessor(new Processor("AMD Ryzen 7 5800X 3.8GHz"))
                .SetPowerSupply(new PowerSupply("SeaSonic PRIME TX 850W Titanium"))
                .AddGraphicCard(new GraphicCard("NVIDIA GeForce RTX 3080 10GB"))
                .AddMemorySticks(new MemoryStick("Crucial Ballistix 8GB DDR4-3600"), 2)
                .Build()
                .Log();
        }
    }
}