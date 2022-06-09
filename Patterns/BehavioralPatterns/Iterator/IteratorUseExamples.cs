using BehavioralPatterns.Iterator.IteratorInsideCollection;
using BehavioralPatterns.Iterator.IteratorOutsideService;
using System;
using System.Collections.Generic;

namespace BehavioralPatterns.Iterator
{
    internal static class IteratorUseExamples
    {
        public static void IteratorInsideCollectionRun()
        {
            var coll = new List<int>() { 1, 2, 3, 4, 5 };
            var iterrableCollection = new IterrableCollection<int>(coll);

            foreach (var item in iterrableCollection)
            {
                Console.WriteLine(item);
            }
        }


        public static void IteratorOutsideCollectionRun()
        {
            var serviceCollection = new ServiceCollection(new List<Service>() { new DeliverByCourier(new Order()) { Name = "deliverByCourier" }, new TakeAway(new Order()) { Name = "takeAway" } });

            foreach (var service in serviceCollection)
            {
                Console.WriteLine(service.Name);
            }
        }
    }
}
