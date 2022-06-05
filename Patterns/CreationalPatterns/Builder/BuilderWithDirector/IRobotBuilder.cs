namespace CreationalPatterns.Builder.BuilderWithDirector
{
    public interface IRobotBuilder
    {
        void SetMovementSystem();
        void SetWeapon();
        void PlaceBattery();
        void ProvideArmor();

        Robot GetRobot();
    }
}
