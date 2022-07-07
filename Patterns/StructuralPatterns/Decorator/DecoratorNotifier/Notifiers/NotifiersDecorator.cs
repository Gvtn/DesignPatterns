namespace StructuralPatterns.Decorator.DecoratorNotifier.Notifiers
{
    internal class NotifiersDecorator : NotifierBase
    {
        protected List<NotifierBase> Notifiers;
        public NotifiersDecorator()
        {
                Notifiers = new List<NotifierBase>();
        }

        public NotifiersDecorator AddToNotifiers(NotifierBase notifier)
        {
            Notifiers.Add(notifier);
            return this;
        }

        public override void Notify()
        {
            foreach (var item in Notifiers)
            {
                item.Notify();
            }
        }
    }
}
