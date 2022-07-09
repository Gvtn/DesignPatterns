using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight.FlyweightWithFactory
{
    internal static class FlyweightWIthFactoryRunner
    {
        internal static void Run()
        {
            Console.WriteLine("Creating Crusher sword");
            Sword crusher = Blacksmith.CreateSword("Crusher");
            Console.WriteLine("Creating Cutter sword");
            Sword cutter = Blacksmith.CreateSword("Cutter");

            Console.WriteLine($"Are this {crusher.Name} and {cutter.Name} are simmilar swords? This is {cutter.Image == crusher.Image}"); 
        }
    }
}
