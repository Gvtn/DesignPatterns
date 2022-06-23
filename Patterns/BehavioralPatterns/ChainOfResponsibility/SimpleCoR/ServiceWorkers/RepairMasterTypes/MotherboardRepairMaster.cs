using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR.ServiceWorkers
{
    internal class MotherboardRepairMaster : ServiceWorker
    {
        public MotherboardRepairMaster(SpecialistsLevel specialistLevel)
        {
            SpecialistsLevel = specialistLevel;
            _detailRepairer = RepairerFactory.CreateServiceWorker(specialistLevel);
        }

        public override Laptop Repair(Laptop laptop)
        {
            if (laptop.Motherboard.IsNotWorking)
                _detailRepairer.RepairDetail(laptop.Motherboard);

            return base.Repair(laptop);
        }
    }
}
