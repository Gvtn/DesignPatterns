using CreationalPatterns.Domain;
using CreationalPatterns.Factories;

namespace CreationalPatterns.FactoryMethod
{
    internal static class FactoryCreator
    {
        public static MembershipFactory GetFactory(string membershipType) =>
            membershipType.ToLower() switch
            {
                "g" => new GymMembershipFactory(100, "Basic membership"),
                "p" => new GymPlusPoolMembershipFactory(250, "Good price membership"),
                "t" => new PersonalTrainingMembershipFactory(400, "Best for professionals"),
                _ => null
            };
    }
}