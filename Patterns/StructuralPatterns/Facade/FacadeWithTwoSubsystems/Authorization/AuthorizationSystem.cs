using StructuralPatterns.Facade.FacadeWithTwoSubsystems.DbConnection;

namespace StructuralPatterns.Facade.FacadeWithTwoSubsystems.Authorization
{
    internal class AuthorizationSystem
    {
        private readonly IDbInterraction _dbInterraction;
        public AuthorizationSystem(IDbInterraction dbInterraction)
        {
            _dbInterraction = dbInterraction;
        }

        public User FindUserByLogin(string login)
        {
            User user = _dbInterraction.GetUserByLogin(login);

            return user;
        }

        public User CreateLogin(string login, string mail)
        {
            User user = new User()
            {
                Login = login,
                Mail = mail
            };

            _dbInterraction.CreateNewUser(user);

            return user;
        }

        public User GetDefaultUser()
        {
            User user = _dbInterraction.GetDefaultUser();

            return user;
        }
    }
}