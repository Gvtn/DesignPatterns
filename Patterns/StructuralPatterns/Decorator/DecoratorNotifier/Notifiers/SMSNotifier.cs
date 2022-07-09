namespace StructuralPatterns.Decorator.DecoratorNotifier.Notifiers
{
    internal class SMSNotifier : NotifierBase
    {
        public override void Notify()
        {
            Console.WriteLine("Notification via SMS");
        }
    }
}
