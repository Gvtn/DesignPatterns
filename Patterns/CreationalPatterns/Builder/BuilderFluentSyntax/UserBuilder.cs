namespace CreationalPatterns.Builder.BuilderFluentSyntax
{
    internal class UserBuilder
    {
        private User _user;
        public UserBuilder()
        {
            _user = new User();
        }

        public UserBuilder SetName(string name)
        {
            _user.Name = name;
            return this;
        }

        public UserBuilder SetEmail(string email)
        {
            _user.Email = email;
            return this;
        }

        public UserBuilder SetPassword(string password)
        {
            _user.Password = password;
            return this;
        }

        public UserBuilder SetLogin(string login)
        {
            _user.Login = login;
            return this;
        }

        public static implicit operator User(UserBuilder userBuilder)
        {
            return userBuilder._user;
        }
    }
}
