using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace DesignPatterns.Common
{
    public class Computer
    {
        public Motherboard Motherboard { get; }
        public Processor Processor { get; }
        public PowerSupply PowerSupply { get; }
        public List<GraphicCard> GraphicCards { get; }
        public List<MemoryStick> MemorySticks { get; }

        public Computer(Motherboard motherboard,
            Processor processor,
            PowerSupply powerSupply,
            List<GraphicCard> graphicCards,
            List<MemoryStick> memoryStick)
        {
            Motherboard = motherboard;
            Processor = processor;
            PowerSupply = powerSupply;
            GraphicCards = graphicCards;
            MemorySticks = memoryStick;
        }

        public void Log()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Motherboard : {Motherboard}");
            sb.AppendLine($"Processor : {Processor}");
            sb.AppendLine($"Power Supply : {PowerSupply}");

            foreach (var card in GraphicCards)
            {
                sb.AppendLine($"Graphic Card : {card}");
            }

            foreach (var stick in MemorySticks)
            {
                sb.AppendLine($"Memory Stick : {stick}");
            }
            
            Debug.Log(sb);
        }
    }
}
