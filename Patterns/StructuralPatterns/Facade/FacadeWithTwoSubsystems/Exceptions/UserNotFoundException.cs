namespace StructuralPatterns.Facade.FacadeWithTwoSubsystems.Exceptions
{
    internal class UserNotFoundException : Exception
    {
        public UserNotFoundException(string? message) : base(message)
        {
        }
    }
}
