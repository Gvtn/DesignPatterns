using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight.FlyweightWithFactory
{
    internal static class Blacksmith
    {
        private static readonly List<WeaponImage> CraftedWeapons = new List<WeaponImage>();

        internal static Sword CreateSword(string name)
        {
            WeaponImage s;
            s = CraftedWeapons.Find((w) => w is SwordImage);
            if (s is null)
            {
                s = new SwordImage(new byte[5]);
                CraftedWeapons.Add(s);
            }

            return new Sword(name, s);
        }
    }
}
