using BehavioralPatterns.ChainOfResponsibility.SimpleCoR.NotebookDetails;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR
{
    internal class LaptopBuilder
    {
        private Laptop _laptop;
        public LaptopBuilder()
        {
            _laptop = new Laptop();
        }

        public LaptopBuilder AddScreen(Screen screen)
        {
            _laptop.Screen = screen;
            return this;
        }

        public LaptopBuilder AddKeyboard(Keyboard keyboard)
        {
            _laptop.Keyboard = keyboard;
            return this;
        }

        public LaptopBuilder AddMotherboard(Motherboard motherboard)
        {
            _laptop.Motherboard = motherboard;
            return this;
        }
        public LaptopBuilder AddGraphicsCard(GraphicsCard graphicsCard)
        {
            _laptop.GraphicsCard = graphicsCard;
            return this;
        }

        public Laptop Build()
        {
            if(_laptop.Screen == null)
                _laptop.Screen = new Screen()
                { 
                    Series = "Default",
                    BreakageSeverity = BreakageSeverity.None
                };
            if (_laptop.Keyboard == null)
                _laptop.Keyboard = new Keyboard()
                {
                    Series = "Default",
                    BreakageSeverity = BreakageSeverity.None
                };
            if (_laptop.Motherboard == null)
                _laptop.Motherboard = new Motherboard()
                {
                    Series = "Default",
                    BreakageSeverity = BreakageSeverity.None
                };

            return _laptop;
        }
    }
}
