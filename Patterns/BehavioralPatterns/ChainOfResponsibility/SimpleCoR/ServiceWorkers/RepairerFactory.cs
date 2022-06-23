using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR.ServiceWorkers
{
    internal static class RepairerFactory
    {
        public static IDetailRepairer CreateServiceWorker(SpecialistsLevel specialistsLevel)
        {
            switch (specialistsLevel)
            {
                case SpecialistsLevel.Junior:
                    return new JuniorRepairer();
                case SpecialistsLevel.Middle:
                    return new MiddleRepairer();
                case SpecialistsLevel.Senior:
                    return new SeniorRepairer();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
