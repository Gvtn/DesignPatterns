using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Prototype.ShallowVsDeepCopy
{
    internal static class ShallowVsDeepCopyRunner
    {
        internal static void Run()
        {
            var firstObject = new SomeObject() { Name = "Oleg", Number = 1, IntIdValue = new SomeObject.IntId() { Id = 1 } };
            var shallowClone = firstObject.ShallowCopy();
            var deepClone = firstObject.DeepCopy();

            Console.WriteLine("Original values:");
            Console.WriteLine("   original: ");
            DisplayValues(firstObject);
            Console.WriteLine("   shallow clone:");
            DisplayValues(shallowClone);
            Console.WriteLine("   deep clone:");
            DisplayValues(deepClone);

            firstObject.Name = "Ne Oleg";
            firstObject.Number = 2;
            firstObject.IntIdValue.Id = 2;

            Console.WriteLine("After change");
            Console.WriteLine("   original: ");
            DisplayValues(firstObject);
            Console.WriteLine("   shallow clone:");
            DisplayValues(shallowClone);
            Console.WriteLine("   deep clone:");
            DisplayValues(deepClone);
        }


        private static void DisplayValues(SomeObject o)
        {
            Console.WriteLine("      Name: {0:s}, Number: {1:d}", o.Name, o.Number);
            Console.WriteLine("      Value: {0:d}", o.IntIdValue.Id);
        }
    }
}
