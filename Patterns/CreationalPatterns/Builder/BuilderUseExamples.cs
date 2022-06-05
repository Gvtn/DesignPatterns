using CreationalPatterns.Builder.BuilderFluentSyntax;
using CreationalPatterns.Builder.BuilderWithDirector;

namespace CreationalPatterns.Builder
{
    public static class BuilderUseExamples
    {
        public static void BuilderWithDirectorRun()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("--> Builder With Director example");

            var director = new Director();
            List<IRobotBuilder> robotBuilders = new List<IRobotBuilder>()
            {
                new FighterRobotBuilder(),
                new FlyingFighterRobotBuilder(),
                new TransportRobotBuilder()
            };

            Robot robot;
            foreach (var builder in robotBuilders)
            {
                director.Construct(builder);
                robot = builder.GetRobot();
                robot.Display();
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('\n', 2));
        }

        public static void BuilderFluentSyntaxRun()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("--> Builder Fluent Syntax example");

            User user = new User().CreateBuilder().SetPassword("pass").SetEmail("email");
            Console.WriteLine($"users password {user.Password} email {user.Email}");

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('\n', 2));
        }
    }
}
