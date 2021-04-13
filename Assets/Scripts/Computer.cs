namespace DesignPattern.FluentBuilder
{
    public class Computer
    {
        private string _processor;
        private string _graphicCard;
        private string _powerSupply;

        public Computer() { }
        
        public Computer(string processor, string graphicCard, string powerSupply)
        {
            _processor = processor;
            _graphicCard = graphicCard;
            _powerSupply = powerSupply;
        }
    }
}
