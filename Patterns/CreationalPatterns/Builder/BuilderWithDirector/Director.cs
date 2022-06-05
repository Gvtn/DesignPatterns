namespace CreationalPatterns.Builder.BuilderWithDirector
{
    internal class Director
    {
        public void Construct(IRobotBuilder robotBuilder)
        {
            robotBuilder.PlaceBattery();
            robotBuilder.SetWeapon();
            robotBuilder.SetMovementSystem();
            robotBuilder.ProvideArmor();
        }
    }
}
