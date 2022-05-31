using System;

namespace BehavioralPatterns.Observer.ObserverUsingEvents.BirdTypes
{
    internal abstract class Bird : IFlyer
    {
        public string Specie { get; }
        public string Color { get; }
        public int Height => _currentHeight;

        private int _currentHeight = 0;
        private Random _random = new Random();

        public Bird(string specie, string color)
        {
            Color = color;
            Specie = specie;
        }

        protected virtual int SetCurrentHeight()
        {
            _currentHeight = Math.Abs(_currentHeight + _random.Next(-3, 3));
            return _currentHeight;
        }

        public virtual void Fly()
        {
            SetCurrentHeight();
            if (_currentHeight == 0)
                Console.WriteLine($"*{Specie} is walking on ground");
            else
                Console.WriteLine($"*{Specie} is flying at {Height} meters above the ground");
        }
    }
}
