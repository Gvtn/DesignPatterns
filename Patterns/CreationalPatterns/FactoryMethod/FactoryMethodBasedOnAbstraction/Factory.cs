using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.FactoryMethod.FactoryMethodBasedOnAbstraction
{
    internal static class Factory
    {
        public static MusicalInstrument CreateMusicalInstrument(MusicalInstrumentFactory instrumentFactory)
        {
            return instrumentFactory.CreateMusicalInstrument();
        }
    }
}
