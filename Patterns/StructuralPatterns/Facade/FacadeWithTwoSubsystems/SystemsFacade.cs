using StructuralPatterns.Facade.FacadeWithTwoSubsystems.Authorization;
using StructuralPatterns.Facade.FacadeWithTwoSubsystems.CreatingOrder;
using StructuralPatterns.Facade.FacadeWithTwoSubsystems.DbConnection;
using StructuralPatterns.Facade.FacadeWithTwoSubsystems.Exceptions;

namespace StructuralPatterns.Facade.FacadeWithTwoSubsystems
{
    internal class SystemsFacade
    {
        private readonly CreatingOrderSystem _creatingOrderSystem;
        private readonly AuthorizationSystem _authorizationSystem;
        private readonly IDbInterraction _dbInterraction;
        public SystemsFacade()
        {
            _dbInterraction = new DbInterraction();
            _authorizationSystem = new AuthorizationSystem(_dbInterraction);
            _creatingOrderSystem = new CreatingOrderSystem(_dbInterraction);
        }

        public bool AccountPromptAsk()
        {
            Console.WriteLine("Do You have an existing account? Y/N");
            bool yesOrNo = default;
            MakeactionAfterUserPromptedYesOrNo(() => yesOrNo = true, () => yesOrNo = false);

            return yesOrNo;
        }

        public User LoginExistsActions()
        {
            bool isLoginNotFound = true;
            User user = default;

            Console.Write("Type your login to continue   ");
            string login = Console.ReadLine();

            try
            {
                user = _authorizationSystem.FindUserByLogin(login);

                return user;
            }
            catch (UserNotFoundException ex)
            {
                Console.WriteLine("User not found. Do you want to try again? Y/N");
                MakeactionAfterUserPromptedYesOrNo(
                    () => user = LoginExistsActions(),
                    () => user = LoginNotCreatedActions(login)
                    );
            }

            return user;
        }

        public int GetOrdersForUser(User user)
        {
            return _creatingOrderSystem.GetOrdersForUser(user);
        }

        private User LoginNotCreatedActions(string login)
        {
            User user = default;

            Console.WriteLine($"Do you want to create user with current login? Y/N");
            MakeactionAfterUserPromptedYesOrNo(
                    () => user = CreateLogin(login),
                    () => user = LoginNotCreatedActions()
                    );

            return user;
        }

        public User LoginNotCreatedActions()
        {
            User user = default;

            Console.WriteLine($"Do you want to create user? Y/N");
            MakeactionAfterUserPromptedYesOrNo(
                    () => user = CreateLogin(),
                    () => user = ReturnDefaultUser()
                    );

            return user;
        }

        private string PromptForLogin()
        {
            Console.WriteLine("Type your login");
            return Console.ReadLine();
        }

        private string PromptForMail()
        {
            Console.WriteLine("Type your mail");
            return Console.ReadLine();
        }

        private User CreateLogin(string login = null)
        {
            User user = default;
            try
            {
                if (string.IsNullOrEmpty(login))
                    login = PromptForLogin();
                string mail = PromptForMail();

                user = _authorizationSystem.CreateLogin(login, mail);
            }
            catch (UserCreationException ex)
            {
                user = CreateLogin();
            }
            return user;
        }

        private User ReturnDefaultUser()
        {
            return _authorizationSystem.GetDefaultUser();
        }

        public void CreateOrderForUser(User user)
        {
            _creatingOrderSystem.CreateOrderForUser(user);
        }

        private void MakeactionAfterUserPromptedYesOrNo(Action actionYes, Action actionNo)
        {
            while (true)
            {
                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.Y:
                        actionYes();
                        return;
                    case ConsoleKey.N:
                        actionNo();
                        return;
                }
            }
        }
    }
}