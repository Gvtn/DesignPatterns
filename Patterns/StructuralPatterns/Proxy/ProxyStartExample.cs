using StructuralPatterns.Proxy;

public static class ProxyStartExamples
{
    public static void ProxyToExternalSystemRun()
    {
        IChief chief = new ChiefProxy(new Chief());

        while (true)
        {
            Thread.Sleep(2000);

            Console.Clear();

            Console.WriteLine("Welcome to Cooker!" + Environment.NewLine);
            Console.WriteLine("====== Orders ======" + Environment.NewLine);

            IEnumerable<Order> orders = chief.GetOrders();

            foreach (var order in orders)
            {
                string status = chief.GetStatuses().First(o => o.Key == order.StatusId).Value;

                Console.WriteLine($"{order.Name}\t\t{status}");
            }
        }
    }
}