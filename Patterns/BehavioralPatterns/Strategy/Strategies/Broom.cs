using System;

namespace BehavioralPatterns.Strategy
{
    internal class Broom : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("attacks with a broom.");
        }
    }
}
