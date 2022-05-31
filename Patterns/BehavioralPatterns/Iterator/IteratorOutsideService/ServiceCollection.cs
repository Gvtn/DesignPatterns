using System;
using System.Collections;
using System.Collections.Generic;

namespace BehavioralPatterns.Iterator.IteratorOutsideService
{
    internal class ServiceCollection : IEnumerable<Service>
    {
        private ICollection<Service> _serviceCollection;
        public ICollection<Service> Services { get { return _serviceCollection; } }

        public ServiceCollection(ICollection<Service> serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }
        public IEnumerator<Service> GetEnumerator()
        {
           return new ServiceEnumerator(_serviceCollection);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
