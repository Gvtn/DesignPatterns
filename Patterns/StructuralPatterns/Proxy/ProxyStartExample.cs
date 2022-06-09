using StructuralPatterns.Proxy;

public static class ProxyStartExamples
{
    public static void ProxyToExternalSystemRun()
    {
        IChief chief = new ChiefProxy(new Chief());
        bool flag = true;
        while (flag)
        {
            Console.CancelKeyPress += (o, c) =>
            {
                c.Cancel = true;
                flag = false;
            };
            Thread.Sleep(2000);

            Console.Clear();

            Console.WriteLine("Welcome to Cooker!");
            Console.WriteLine("Press Ctrl+C to move to the next example" + Environment.NewLine);
            Console.WriteLine("====== Orders ======" + Environment.NewLine);

            IEnumerable<Order> orders = chief.GetOrders();

            foreach (var order in orders)
            {
                string status = chief.GetStatuses().First(o => o.Key == order.StatusId).Value;

                Console.WriteLine($"{order.Name}\t\t{status}");
            }
        }
        Console.WriteLine(new string('-', 30));
        Console.WriteLine(new string('\n', 2));
    }
}