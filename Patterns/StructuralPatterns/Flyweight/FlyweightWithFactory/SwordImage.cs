using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight.FlyweightWithFactory
{
    internal class SwordImage : WeaponImage
    {
        public SwordImage(byte[] image) : base(image)
        {
           
        }
    }
}
