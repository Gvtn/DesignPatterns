using System;

namespace BehavioralPatterns.Observer.ObserverUsingEvents
{
    internal class BirdsCaughtInSight : IBirdObserver
    {
        public event Action<IFlyer> WatchingBirdsFlying;

        public void LookAtTheBird(IFlyer bird)
        {
            bird.Fly();
            WatchingBirdsFlying?.Invoke(bird);
        }
    }
}
