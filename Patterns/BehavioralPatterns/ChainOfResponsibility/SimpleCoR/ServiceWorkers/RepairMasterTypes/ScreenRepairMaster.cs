using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR.ServiceWorkers
{
    internal class ScreenRepairMaster : ServiceWorker
    {
        public ScreenRepairMaster(SpecialistsLevel specialistLevel)
        {
            _detailRepairer = RepairerFactory.CreateServiceWorker(specialistLevel);
            SpecialistsLevel = specialistLevel;
        }

        public override Laptop Repair(Laptop laptop)
        {
            if (laptop.Screen.IsNotWorking)
                _detailRepairer.RepairDetail(laptop.Screen);

            return base.Repair(laptop);
        }
    }
}
