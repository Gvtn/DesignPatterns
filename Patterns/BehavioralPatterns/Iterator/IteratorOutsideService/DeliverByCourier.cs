namespace BehavioralPatterns.Iterator.IteratorOutsideService
{
    internal class DeliverByCourier : Service
    {
        public DeliverByCourier(Order order)
        {
            OrderToDeliver = order;
        }

        public Order OrderToDeliver{ get; private set; }

        public Order DeliverOrder()
        {
            return OrderToDeliver;
        }
    }
}
