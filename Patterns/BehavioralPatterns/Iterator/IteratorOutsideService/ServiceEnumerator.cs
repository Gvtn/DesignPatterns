using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BehavioralPatterns.Iterator.IteratorOutsideService
{
    internal class ServiceEnumerator : IEnumerator<Service>
    {
        private readonly ICollection<Service> _serviceCollection;
        private int _serviceIndex = -1;

        public ServiceEnumerator(ICollection<Service> serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        public Service Current => _serviceCollection.ElementAt(_serviceIndex);

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            _serviceIndex++;
            if (_serviceIndex < _serviceCollection.Count)
                return true;
            Reset();
            return false;
        }

        public void Reset()
        {
           _serviceIndex = -1;
        }
    }
}
