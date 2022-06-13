using CreationalPatterns.Builder.BuilderFluentSyntax;
using CreationalPatterns.Builder.BuilderWithDirector;
using CreationalPatterns.Builder.BuilderFluentAnotherOne;

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

        public static void BuilderFluentAnotherOneRun()
        {
            List<Employee> employees = new()
            {
                new Employee { Name = "Antonina", Salary = 100 },
                new Employee { Name = "Mykola", Salary = 50 },
                new Employee { Name = "Valentina", Salary = 200 }
            };

            var builder = new EmployeeReportBuilder(employees);
            var director = new EmployeeReportDirector(builder);
            director.Build();

            var report = builder.GetReport();

            Console.WriteLine(report);
        }
    }
}
