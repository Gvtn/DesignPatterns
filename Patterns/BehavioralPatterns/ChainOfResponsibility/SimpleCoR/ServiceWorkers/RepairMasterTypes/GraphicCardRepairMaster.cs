using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR.ServiceWorkers
{
    internal class GraphicCardRepairMaster : ServiceWorker
    {
        public GraphicCardRepairMaster(SpecialistsLevel specialistLevel)
        {
            SpecialistsLevel = specialistLevel;
            _detailRepairer = RepairerFactory.CreateServiceWorker(specialistLevel);
        }

        public override Laptop Repair(Laptop laptop)
        {
            if (laptop.GraphicsCard != null && laptop.GraphicsCard.IsNotWorking)
                _detailRepairer.RepairDetail(laptop.GraphicsCard);

            return base.Repair(laptop);
        }
    }
}
