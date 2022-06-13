using StructuralPatterns.Facade.FacadeWithTwoSubsystems.DbConnection;

namespace StructuralPatterns.Facade.FacadeWithTwoSubsystems.CreatingOrder
{
    internal class CreatingOrderSystem
    {
        private readonly IDbInterraction _dbInterraction;
        public CreatingOrderSystem(IDbInterraction dbInterraction)
        {
            _dbInterraction = dbInterraction;
        }

        public void CreateOrderForUser(User user)
        {
            _dbInterraction.CreateOrderForUser(user);
        }

        public int GetOrdersForUser(User user)
        {
            return _dbInterraction.GetOrdersForUser(user);
        }
    }
}
