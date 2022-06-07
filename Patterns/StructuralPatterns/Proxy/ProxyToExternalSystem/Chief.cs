namespace StructuralPatterns.Proxy;


/// <summary>
/// Боевой класс доступа к внешней системе, который имеет задержки исполнения (вызов БД и т.д.)
/// </summary>
internal class Chief : IChief
{
    public IDictionary<int, string> GetStatuses()
    {
        Dictionary<int, string> statuses = new();

        statuses.Add(1, "ready");
        statuses.Add(2, "not ready");
        statuses.Add(3, "preparing");

        Thread.Sleep(2000);

        return statuses;
    }

    public IEnumerable<Order> GetOrders()
    {
        List<Order> orders = new();

        orders.Add(new Order { Name = "Burger", StatusId = RandomizeStatus() });
        orders.Add(new Order { Name = "Pasta", StatusId = RandomizeStatus() });
        orders.Add(new Order { Name = "Omelette", StatusId = RandomizeStatus() });

        return orders;
    }

    private static int RandomizeStatus() => new Random().Next(1, 4);
}
