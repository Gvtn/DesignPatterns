using CreationalPatterns.Domain;
using CreationalPatterns.Factories;

namespace CreationalPatterns.FactoryMethod
{
    public class FactoryMethod2UseExample
    {
        internal static void FactoryMethod2()
        {
            Console.WriteLine(">>> Welcome to FitnessClub CRM <<<");

            Console.WriteLine("> Enter the membership type you would loke to create: ");
            Console.WriteLine("> G - Gym");
            Console.WriteLine("> P - Gym + Pool");
            Console.WriteLine("> T - personal Training");

            string membershipType = Console.ReadLine();

            MembershipFactory factory = GetFactory(membershipType);
            IMembership membership = factory.GetMembership();

            Console.WriteLine(Environment.NewLine + ">Membership you've just created:" + Environment.NewLine);
            Console.WriteLine(
                $"\tName:\t\t{membership.Name}" + Environment.NewLine +
                $"\tDescription: \t{membership.Description}" + Environment.NewLine +
                $"\tPrice:\t\t{membership.GetPrice()}");

            Console.ReadLine();
        }

        private static MembershipFactory GetFactory(string membershipType) =>
            membershipType.ToLower() switch
            {
                "g" => new GymMembershipFactory(100, "Basic membership"),
                "p" => new GymPlusPoolMembershipFactory(250, "Good price membership"),
                "t" => new PersonalTrainingMembershipFactory(400, "Best for professionals"),
                _ => null
            };
    }
}