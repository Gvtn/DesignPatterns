using BehavioralPatterns.Observer.ObserverUsingEvents.BirdTypes;
using BehavioralPatterns.Observer.ObserverUsingEvents.BirdwatcherTypes;
using System.Collections.Generic;

namespace BehavioralPatterns.Observer.ObserverUsingEvents
{
    internal static class Birdwatching
    {
        private const int Typical_Birdwatcher_Vision_Max_Height_In_Ukraine = 3;
        private const int StartDayTime = 10;
        private const int FinishDayTime = 17;

        public static void BirdwatchingInUkraine()
        {
            var dayTime = StartDayTime;
            var birds = new List<Bird>();
            birds.Add(new Stork("Ciconia ciconia", "white with a bit of black color"));

            var birdwatchers = new List<Birdwatcher>();
            birdwatchers.Add(new Ornitologist(Typical_Birdwatcher_Vision_Max_Height_In_Ukraine));
            birdwatchers.Add(new PasserBy(Typical_Birdwatcher_Vision_Max_Height_In_Ukraine));

            var birdsCoughtInSight = new BirdsCaughtInSight();
            foreach (var birdwatcher in birdwatchers)
            {
                birdsCoughtInSight.WatchingBirdsFlying+= (b) => birdwatcher.WatchBird(b);
            }

            while (dayTime < FinishDayTime)
            {
                foreach (var bird in birds)
                {
                    birdsCoughtInSight.LookAtTheBird(bird);
                }
                dayTime++;
            }
        }
    }
}
