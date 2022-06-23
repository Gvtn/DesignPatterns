using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR.NotebookDetails
{
    [Flags]
    internal enum BreakageSeverity
    {
        None = 0,
        Light = 1,
        Medium = 2,
        Critical = 4,
        LightOrMedium = Light | Medium,     
        LightOrMediumOrCritical = Light | Medium | Critical
    }
}
