namespace CreationalPatterns.Builder.BuilderFluentSyntax
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }

        public UserBuilder CreateBuilder()
        {
            return new UserBuilder();
        }
    }
}
