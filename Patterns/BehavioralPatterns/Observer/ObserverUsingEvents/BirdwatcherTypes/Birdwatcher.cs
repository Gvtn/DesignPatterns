using System;

namespace BehavioralPatterns.Observer.ObserverUsingEvents
{
    internal abstract class Birdwatcher : IBirdwatcher
    {
        protected int _maxWatchingHeight;

        public Birdwatcher(int maxWatchingHeight)
        {
            _maxWatchingHeight = maxWatchingHeight;
        }
        public virtual void WatchBird(IFlyer bird)
        {
            
            if(bird.Height < GetWatchingHeight())
                Console.WriteLine($"--> {this.GetType().Name} seeing the bird");
            else
                Console.WriteLine($"--> {this.GetType().Name} can't see the bird");
        }
        protected virtual int GetWatchingHeight()
        {
            return _maxWatchingHeight;
        }
    }
}
