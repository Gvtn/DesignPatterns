using BehavioralPatterns.ChainOfResponsibility.SimpleCoR.NotebookDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR.ServiceWorkers
{
    internal abstract class ServiceWorker : ILaptopRepairHandler
    {
        private ILaptopRepairHandler _nextHandler;
        protected IDetailRepairer _detailRepairer;
        public SpecialistsLevel SpecialistsLevel { get; protected set; }
        public ILaptopRepairHandler SetNext(ILaptopRepairHandler handler)
        {
            _nextHandler = handler;

            return handler;
        }

        public virtual Laptop Repair(Laptop laptop)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Repair(laptop);
            }
            else
            {
                return laptop;
            }
        }
    }
}
