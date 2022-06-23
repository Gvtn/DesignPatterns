using BehavioralPatterns.ChainOfResponsibility.SimpleCoR.NotebookDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR.ServiceWorkers
{
    internal class JuniorRepairer : IDetailRepairer
    {
        public void RepairDetail(AbstractLaptopDetail detail)
        {
            if (detail.BreakageSeverity == BreakageSeverity.Light)
            {
                Console.WriteLine($"{detail.Series} repaired by junior");
                detail.BreakageSeverity = BreakageSeverity.None;
            }
        }
    }
}
