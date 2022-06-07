using CreationalPatterns.Factories;
using CreationalPatterns.FactoryMethod.FactoryMethodBasedOnAbstraction;
using CreationalPatterns.FactoryMethod;
using CreationalPatterns.Domain;

namespace CreationalPatterns.FactoryMethod
{
    public static class FactoryMethodUseExamples
    {
        public static void FactoryMethodBasedOnAbstractionRun()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("--> Factory Method Based On Abstraction example");


            var musicalInstrument = Factory.CreateMusicalInstrument(new DrumsFactory());
            musicalInstrument.MakeSound();
            musicalInstrument =  Factory.CreateMusicalInstrument(new HornFactory());
            musicalInstrument.MakeSound();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('\n', 2));
        }

        internal static void FactoryMethod2()
        {
            Console.WriteLine(">>> Welcome to FitnessClub CRM <<<");

            Console.WriteLine("> Enter the membership type you would loke to create: ");
            Console.WriteLine("> G - Gym");
            Console.WriteLine("> P - Gym + Pool");
            Console.WriteLine("> T - personal Training");

            string membershipType = Console.ReadLine();

            MembershipFactory factory = FactoryCreator.GetFactory(membershipType);
             IMembership membership = factory.GetMembership();

            Console.WriteLine(Environment.NewLine + ">Membership you've just created:" + Environment.NewLine);
            Console.WriteLine(
                $"\tName:\t\t{membership.Name}" + Environment.NewLine +
                $"\tDescription: \t{membership.Description}" + Environment.NewLine +
                $"\tPrice:\t\t{membership.GetPrice()}");

            Console.ReadLine();
        }
    }
}
