using System;

namespace BehavioralPatterns.Strategy
{
    internal class Plunger : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("attacks with a plunger.");
        }
    }
}
