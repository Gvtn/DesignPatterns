namespace CreationalPatterns.Builder.BuilderWithDirector
{
    internal class FlyingFighterRobotBuilder : IRobotBuilder
    {
        private Robot _robot;
        public FlyingFighterRobotBuilder()
        {
            _robot = new Robot();
        }
        public Robot GetRobot()
        {
            return _robot;
        }

        public void PlaceBattery()
        {
            _robot.BatteryLifeTime = RobotParametersEnums.BatteryLifeTime.High;
        }

        public void ProvideArmor()
        {
            _robot.Armor = RobotParametersEnums.Armor.Light;
        }

        public void SetMovementSystem()
        {
            _robot.MovementType = RobotParametersEnums.MovingBy.WingsPlusLegs;
        }

        public void SetWeapon()
        {
            _robot.Gun = RobotParametersEnums.Guns.PlazmaCannon;
        }
    }
}
