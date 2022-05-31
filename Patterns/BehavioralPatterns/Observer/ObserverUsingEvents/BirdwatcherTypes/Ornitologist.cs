namespace BehavioralPatterns.Observer.ObserverUsingEvents.BirdwatcherTypes
{
    internal class Ornitologist : Birdwatcher
    {
        private const int Binoculars_Distance = 5;
        public Ornitologist(int maxWatchingHeight) : base(maxWatchingHeight) { }

        protected override int GetWatchingHeight()
        {
            return UseBinoculars();
        }

        private int UseBinoculars()
        {
            return _maxWatchingHeight + Binoculars_Distance;
        }
    }
}
