namespace StructuralPatterns.Proxy;

/// <summary>
/// Общий интерфейс для внешней системы и Proxy, используется для возможности вызова Proxy вместо конкретной системы напрямую.
/// </summary>
public interface IChief
{
    IDictionary<int, string> GetStatuses();

    IEnumerable<Order> GetOrders();
}
