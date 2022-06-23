using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR.ServiceWorkers
{
    internal class KeyboardRepairMaster : ServiceWorker
    {
        public KeyboardRepairMaster(SpecialistsLevel specialistLevel)
        {
            SpecialistsLevel = specialistLevel;
            _detailRepairer = RepairerFactory.CreateServiceWorker(specialistLevel);
        }

        public override Laptop Repair(Laptop laptop)
        {
            if (laptop.Keyboard.IsNotWorking)
                _detailRepairer.RepairDetail(laptop.Keyboard);

            return base.Repair(laptop);
        }
    }
}
