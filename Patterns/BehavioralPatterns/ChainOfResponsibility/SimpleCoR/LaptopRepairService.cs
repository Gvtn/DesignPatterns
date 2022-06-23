using BehavioralPatterns.ChainOfResponsibility.SimpleCoR.ServiceWorkers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR
{
    internal class LaptopRepairService
    {
        private ScreenRepairMaster _screenMaster;
        private MotherboardRepairMaster _motherboardMaster;
        private KeyboardRepairMaster _keyboardMaster;
        private GraphicCardRepairMaster _graphicCardMaster;

        public LaptopRepairService()
        {
            _screenMaster = new ScreenRepairMaster((SpecialistsLevel)new Random().Next(1, 4));
            _motherboardMaster = new MotherboardRepairMaster((SpecialistsLevel)new Random().Next(1, 4));
            _keyboardMaster = new KeyboardRepairMaster((SpecialistsLevel)new Random().Next(1, 4));
            _graphicCardMaster = new GraphicCardRepairMaster((SpecialistsLevel)new Random().Next(1, 4));
            _keyboardMaster.SetNext(_screenMaster).SetNext(_motherboardMaster).SetNext(_graphicCardMaster);
        }

        public Laptop RepairLaptop(Laptop laptop)
        {
            _keyboardMaster.Repair(laptop);

            return laptop;
        }

        public void ViewListOfSpecialists()
        {
            Console.WriteLine($"    List of masters:");
            Console.WriteLine($"        Screen master is {_screenMaster.SpecialistsLevel} level, Motherboard master is {_motherboardMaster.SpecialistsLevel} level, " +
                $"Keyboard master is {_keyboardMaster.SpecialistsLevel} level, Graphic Card master is {_graphicCardMaster.SpecialistsLevel} level");
        }
    }
}
