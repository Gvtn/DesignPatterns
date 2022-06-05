using static CreationalPatterns.Builder.BuilderWithDirector.RobotParametersEnums;

namespace CreationalPatterns.Builder.BuilderWithDirector
{
    public class Robot
    {
        public MovingBy MovementType { get; set; }
        public Guns Gun { get; set; }
        public BatteryLifeTime BatteryLifeTime { get; set; }
        public Armor Armor { get; set; }

        public void Display()
        {
            Console.WriteLine($"This robot move by {MovementType}, " +
                $"have {Gun} as weapon, battery with {BatteryLifeTime} capacity and {Armor} armor");
        }
    }
}
