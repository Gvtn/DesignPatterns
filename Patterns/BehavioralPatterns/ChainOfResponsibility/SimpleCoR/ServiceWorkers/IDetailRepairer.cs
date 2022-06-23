using BehavioralPatterns.ChainOfResponsibility.SimpleCoR.NotebookDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR.ServiceWorkers
{
    internal interface IDetailRepairer
    {
        internal void RepairDetail(AbstractLaptopDetail detail);
    }
}
