using BehavioralPatterns.ChainOfResponsibility.SimpleCoR.NotebookDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR.ServiceWorkers
{
    internal class MiddleRepairer : IDetailRepairer
    {
        private BreakageSeverity _compitancyLevel = BreakageSeverity.LightOrMedium;
        public void RepairDetail(AbstractLaptopDetail detail)
        {
            if (detail.BreakageSeverity == (_compitancyLevel & detail.BreakageSeverity))
            {
                Console.WriteLine($"{detail.Series} repaired by middle");
                detail.BreakageSeverity = BreakageSeverity.None;
            }
        }
    }
}
