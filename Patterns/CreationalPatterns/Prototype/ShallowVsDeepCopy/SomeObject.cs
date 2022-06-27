using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Prototype.ShallowVsDeepCopy
{
    internal class SomeObject
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public IntId IntIdValue { get; set; }

        public SomeObject ShallowCopy()
        {
            return (SomeObject)MemberwiseClone();
        }

        public SomeObject DeepCopy()
        {
            return new SomeObject() { Name = Name, Number = Number, IntIdValue = new IntId() { Id = IntIdValue.Id} };
        }

        internal class IntId
        {
            public int Id { get; set; }
        }
    }
}
