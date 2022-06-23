using BehavioralPatterns.ChainOfResponsibility.SimpleCoR.NotebookDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR.ServiceWorkers
{
    internal class SeniorRepairer : IDetailRepairer
    {
        private static BreakageSeverity _seniorCompitency = BreakageSeverity.LightOrMediumOrCritical;
        public void RepairDetail(AbstractLaptopDetail detail)
        {

            if (detail.BreakageSeverity == (_seniorCompitency & detail.BreakageSeverity))
            {
                Console.WriteLine($"{detail.Series} repaired by senior");
                detail.BreakageSeverity = BreakageSeverity.None;
            }
        }
    }
}
