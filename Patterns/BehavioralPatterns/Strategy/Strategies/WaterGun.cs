using System;

namespace BehavioralPatterns.Strategy
{
    internal class WaterGun : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("attacks with a water gun.");
        }
    }
}
