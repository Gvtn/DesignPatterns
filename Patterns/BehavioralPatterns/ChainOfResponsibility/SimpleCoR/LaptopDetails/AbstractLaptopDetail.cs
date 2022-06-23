using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR.NotebookDetails
{
    internal abstract class AbstractLaptopDetail
    {
        public string Series { get; set; }
        public bool IsWorking => BreakageSeverity == BreakageSeverity.None;
        public bool IsNotWorking => !IsWorking;
        public BreakageSeverity BreakageSeverity { get; set; }
    }
}
