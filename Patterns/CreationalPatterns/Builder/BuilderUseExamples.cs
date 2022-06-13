using CreationalPatterns.Builder.BuilderFluentSyntax;
using CreationalPatterns.Builder.BuilderWithDirector;

namespace CreationalPatterns.Builder
{
    public static class BuilderUseExamples
    {
        public static void BuilderWithDirectorRun()
        {
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
        }

        public static void BuilderFluentSyntaxRun()
        {
            User user = new User().CreateBuilder().SetPassword("pass").SetEmail("email");
            Console.WriteLine($"users password {user.Password} email {user.Email}");
        }
    }
}
