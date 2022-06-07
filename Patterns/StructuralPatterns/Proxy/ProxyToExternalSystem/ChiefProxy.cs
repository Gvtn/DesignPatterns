namespace StructuralPatterns.Proxy;

/// <summary>
/// Типичный пример испольозвания Proxy для логирования и кэширования.
/// Proxy, который логирует запросы к GetOrders() и логирует запрос к GetStatuses().
/// Еще бывает использование Proxy для контроля доступа к системе через проверку прав внутри Proxy.
/// Использование кэша приводит к осутствию задержки в обработке полученных даных.
/// </summary>
internal class ChiefProxy : IChief
{
    private readonly Chief _chief;
    private IDictionary<int, string>? _statuses;

    public ChiefProxy(Chief chief)
    {
        _chief = chief;
    }

    public IEnumerable<Order> GetOrders()
    {
        Console.WriteLine($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] GetOrders()" + Environment.NewLine);

        return _chief.GetOrders();
    }

    public IDictionary<int, string> GetStatuses()
    {
        if (_statuses is null)
        {
            _statuses = _chief.GetStatuses();
        }

        return _statuses;
    }
}
