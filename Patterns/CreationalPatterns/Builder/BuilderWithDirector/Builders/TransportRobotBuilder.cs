namespace CreationalPatterns.Builder.BuilderWithDirector
{
    internal class TransportRobotBuilder : IRobotBuilder
    {
        private Robot _robot;
        public TransportRobotBuilder()
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
            _robot.Armor = RobotParametersEnums.Armor.Heavy;
        }

        public void SetMovementSystem()
        {
            _robot.MovementType = RobotParametersEnums.MovingBy.Wheels;
        }

        public void SetWeapon()
        {
            _robot.Gun = RobotParametersEnums.Guns.Nothing;
        }
    }
}
