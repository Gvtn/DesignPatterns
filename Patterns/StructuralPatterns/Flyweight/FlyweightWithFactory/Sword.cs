using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight.FlyweightWithFactory
{
    internal class Sword : Weapon
    {
        public Sword(string name, WeaponImage image) : base(name, image)
        {
        }
    }
}
