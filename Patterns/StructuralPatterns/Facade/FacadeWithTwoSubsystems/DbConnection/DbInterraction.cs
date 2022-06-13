using StructuralPatterns.Facade.FacadeWithTwoSubsystems.Exceptions;

namespace StructuralPatterns.Facade.FacadeWithTwoSubsystems.DbConnection
{
    internal class DbInterraction : IDbInterraction
    {
        public DbInterraction()
        {

        }
        public void CreateNewUser(User user)
        {
            try
            {
                using var serviceContext = new ServiceContext();
                serviceContext.Add(user);
                serviceContext.SaveChanges(true);
            }
            catch {
                throw new UserCreationException();
            }
        }

        public void CreateOrderForUser(User user)
        {
            using var serviceContext = new ServiceContext();
            User userInDb = serviceContext.Users.First((u) => u.Login.ToLower() == user.Login.ToLower());
            userInDb.OrdersCount++;
            serviceContext.Users.Update(userInDb);
            serviceContext.SaveChanges(true);
        }

        public User GetDefaultUser()
        {
            using var serviceContext = new ServiceContext();

            return serviceContext.Users.First((u) => u.Login.ToLower() == "defaultuser");
        }

        public int GetOrdersForUser(User user)
        {
            using var serviceContext = new ServiceContext();

            return serviceContext.Users.First((u) => u.Login.ToLower() == user.Login.ToLower()).OrdersCount;
        }

        public User GetUserByLogin(string login)
        {
            using var serviceContext = new ServiceContext();
            User user;
            try
            {
                user = serviceContext.Users.First((u) => u.Login.ToLower() == login.ToLower());
            }
            catch
            {
                throw new UserNotFoundException("No such user");
            }

            return user;
        }
    }
}
