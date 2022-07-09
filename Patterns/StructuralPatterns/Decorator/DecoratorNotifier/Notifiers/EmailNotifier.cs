namespace StructuralPatterns.Decorator.DecoratorNotifier.Notifiers
{
    internal class EmailNotifier : NotifierBase
    {
        public override void Notify()
        {
            Console.WriteLine("Notification via Email");
        }
    }
}
