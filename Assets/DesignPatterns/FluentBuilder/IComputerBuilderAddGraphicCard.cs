using System.Collections.Generic;
using DesignPatterns.Common;

namespace DesignPatterns.FluentBuilder
{
    public interface IComputerBuilderAddGraphicCard
    {
        public ComputerBuilder AddGraphicCard(GraphicCard graphicCard);
        public ComputerBuilder AddGraphicCards(params GraphicCard[] graphicCards);
        public ComputerBuilder AddGraphicCards(IEnumerable<GraphicCard> graphicCards);
    }
}