namespace StructuralPatterns.Proxy;

public struct Order
{
    public Order()
    {
        Id = Guid.NewGuid();
        Name = default;
        StatusId = default;
    }

    public Guid Id { get; set; }

    public string? Name { get; set; }
    public int StatusId { get; set; }
}