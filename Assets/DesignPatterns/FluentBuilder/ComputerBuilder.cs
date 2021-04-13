using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FluentBuilder
{
    public sealed class ComputerBuilder : 
        IComputerBuilderSetMotherboard,
        IComputerBuilderSetProcessor,
        IComputerBuilderSetPowerSupply,
        IComputerBuilderAddGraphicCard,
        IComputerBuilderAddMemoryStick,
        IComputerBuilder
    {
        private Motherboard _motherboard;
        private Processor _processor;
        private PowerSupply _powerSupply;
        private List<GraphicCard> _graphicCards = new List<GraphicCard>();
        private List<MemoryStick> _memorySticks = new List<MemoryStick>();

        public static IComputerBuilderSetMotherboard Create() => new ComputerBuilder();

        #region IComputerBuilderSetMotherboard

        public IComputerBuilderSetProcessor SetMotherboard(Motherboard motherboard)
        {
            _motherboard = motherboard;
            return this;
        }

        #endregion IComputerBuilderSetMotherboard

        #region IComputerBuilderSetProcessor
        
        public IComputerBuilderSetPowerSupply SetProcessor(Processor processor)
        {
            _processor = processor;
            return this;
        }

        #endregion IComputerBuilderSetProcessor

        #region IComputerBuilderSetPowerSupply

        public ComputerBuilder SetPowerSupply(PowerSupply powerSupply)
        {
            _powerSupply = powerSupply;
            return this;
        }

        #endregion IComputerBuilderSetPowerSupply
        
        #region IComputerBuilderAddGraphicCard

        public ComputerBuilder AddGraphicCard(GraphicCard graphicCard)
        {
            _graphicCards.Add(graphicCard);
            return this;
        }

        public ComputerBuilder AddGraphicCards(params GraphicCard[] graphicCards)
        {
            _graphicCards.AddRange(graphicCards);
            return this;
        }

        
        public ComputerBuilder AddGraphicCards(IEnumerable<GraphicCard> graphicCards)
        {
            _graphicCards.AddRange(graphicCards);
            return this;
        }

        #endregion IComputerBuilderAddGraphicCard

        #region IComputerBuilderAddMemoryStick

        public ComputerBuilder AddMemoryStick(MemoryStick memoryStick)
        {
            _memorySticks.Add(memoryStick);
            return this;
        }

        public ComputerBuilder AddMemorySticks(MemoryStick memoryStick, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (_memorySticks.Count == _motherboard.MemorySlots)
                {
                    Debug.LogError($"[{GetType().Name}] Insufficient motherboard RAM slots");
                    return this;
                }
                
                _memorySticks.Add(memoryStick);
            }

            return this;
        }

        public ComputerBuilder AddMemorySticks(IEnumerable<MemoryStick> memorySticks)
        {
            _memorySticks.AddRange(memorySticks);
            return this;
        }

        public ComputerBuilder AddMemorySticks(params MemoryStick[] memorySticks)
        {
            _memorySticks.AddRange(memorySticks);
            return this;
        }

        #endregion IComputerBuilderAddMemoryStick
        
        #region IComputerBuilder

        public Computer Build()
        {
            return new Computer(_motherboard, _processor, _powerSupply, _graphicCards, _memorySticks);
        }

        #endregion IComputerBuilder
    }
}