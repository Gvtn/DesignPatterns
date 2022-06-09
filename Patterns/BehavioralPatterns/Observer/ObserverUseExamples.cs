using BehavioralPatterns.Observer.ObserverUsingEvents;
using System;

namespace BehavioralPatterns.Observer
{
    internal static class ObserverUseExamples
    {
        public static void ObserverUsingEventsRun()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("--> ");

            Birdwatching.BirdwatchingInUkraine();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('\n', 2));
        }
    }
}
