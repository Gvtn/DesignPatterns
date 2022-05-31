using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BehavioralPatterns.Iterator.IteratorInsideCollection
{
    internal class IterrableCollection<T> : IEnumerable<T>, IEnumerator<T>
    {
        private readonly ICollection<T> _collection;
        private int _currentItemIndex = -1;
        public IterrableCollection(ICollection<T> collection)
        {
            _collection = collection;
        }
        public T Current => _collection.ElementAt(_currentItemIndex);

        object IEnumerator.Current => Current;
        public IEnumerator<T> GetEnumerator() => new IterrableCollection<T>(_collection);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            _currentItemIndex++;
            if (_currentItemIndex < _collection.Count)
            {
                return true;
            }
            else
            { 
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            _currentItemIndex = 0;
        }
    }
}
