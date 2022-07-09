using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight.FlyweightWithFactory
{
    internal abstract class WeaponImage
    {
        protected readonly byte[] Image;

        protected WeaponImage(byte[] image)
        {
            Image = image;
        }
    }
}
