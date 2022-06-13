using StructuralPatterns.Facade.FacadeWithTwoSubsystems;

namespace StructuralPatterns.Facade
{
    internal static class FacadeUseExamples
    {
        public static void FacadeWithTwoSubsystemsRun()
        {
            bool flag = true;
            var facade = new SystemsFacade();
            var consoleCancelEventHandler = new ConsoleCancelEventHandler((o, c) =>
            {
                c.Cancel = true;
                flag = false;
            });
            Console.WriteLine("Press Ctrl+C to move to the next example" + Environment.NewLine);

            while (flag)
            {
                var isAccountExisting = facade.AccountPromptAsk();
                User user;
                if (isAccountExisting)
                    user = facade.LoginExistsActions();
                else
                    user = facade.LoginNotCreatedActions();

                facade.CreateOrderForUser(user);
                int orders = facade.GetOrdersForUser(user);
                Console.WriteLine($"Order was created for {user.Login} user. It's {orders} order");
            }
        }
    }
}