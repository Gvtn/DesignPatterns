namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR
{
    internal interface ILaptopRepairHandler
    {
        ILaptopRepairHandler SetNext(ILaptopRepairHandler handler);

        Laptop Repair(Laptop laptop);
    }
}
