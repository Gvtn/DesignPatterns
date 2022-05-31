namespace BehavioralPatterns.Iterator.IteratorOutsideService
{
    internal class TakeAway : Service
    {
        public TakeAway(Order order)
        {
            OrderToTake = order;
        }

        public Order OrderToTake { get; private set; }

        public Order GiveOrderToClient(int orderCost)
        {
            return OrderToTake;
        }
    }
}
