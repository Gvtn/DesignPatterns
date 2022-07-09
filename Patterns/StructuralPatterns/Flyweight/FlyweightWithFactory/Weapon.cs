using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight.FlyweightWithFactory
{
    internal abstract class Weapon
    {
        public readonly string Name;
        public readonly WeaponImage Image;
        public Weapon(string name, WeaponImage weaponImage)
        {
            Name = name;
        }
    }
}
