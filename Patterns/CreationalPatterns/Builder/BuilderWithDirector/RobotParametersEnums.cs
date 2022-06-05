namespace CreationalPatterns.Builder.BuilderWithDirector
{
    public static class RobotParametersEnums
    {
        public enum MovingBy
        {
            Wheels,
            Legs,
            Wings,
            WingsPlusLegs
        }
        public enum Guns
        {
            Nothing,
            Pistol,
            AutomaticRifle,
            GranadeLauncher,
            PlazmaCannon
        }
        public enum BatteryLifeTime
        {
            Low,
            Medium,
            High
        }
        public enum Armor
        {
            Light,
            Medium,
            Heavy
        }
    }
}
