namespace CreationalPatterns.Builder.BuilderWithDirector
{
    internal class FighterRobotBuilder : IRobotBuilder
    {
        private Robot _robot;
        public FighterRobotBuilder()
        {
            _robot = new Robot();
        }
        public Robot GetRobot()
        {
            return _robot;
        }

        public void PlaceBattery()
        {
            _robot.BatteryLifeTime = RobotParametersEnums.BatteryLifeTime.Medium;
        }

        public void ProvideArmor()
        {
            _robot.Armor = RobotParametersEnums.Armor.Medium;
        }

        public void SetMovementSystem()
        {
            _robot.MovementType = RobotParametersEnums.MovingBy.Legs;
        }

        public void SetWeapon()
        {
            _robot.Gun = RobotParametersEnums.Guns.AutomaticRifle;
        }
    }
}
