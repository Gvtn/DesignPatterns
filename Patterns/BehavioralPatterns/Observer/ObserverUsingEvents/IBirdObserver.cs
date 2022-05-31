using System;

namespace BehavioralPatterns.Observer.ObserverUsingEvents
{
    internal interface IBirdObserver
    {
        event Action<IFlyer> WatchingBirdsFlying;
    }
}
