using CreationalPatterns.Domain;

namespace CreationalPatterns.Factories
{
    internal abstract class MembershipFactory
    {
        public abstract IMembership GetMembership();
    }
}
