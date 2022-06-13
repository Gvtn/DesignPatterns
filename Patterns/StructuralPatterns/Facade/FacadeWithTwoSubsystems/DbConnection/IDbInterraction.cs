namespace StructuralPatterns.Facade.FacadeWithTwoSubsystems.DbConnection
{
    interface IDbInterraction
    {
        User GetUserByLogin (string login);
        void CreateNewUser(User user);
        User GetDefaultUser();
        void CreateOrderForUser(User user);
        int GetOrdersForUser(User user);
    }
}
