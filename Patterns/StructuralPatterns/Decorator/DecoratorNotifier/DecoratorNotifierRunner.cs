using StructuralPatterns.Decorator.DecoratorNotifier.Notifiers;

namespace StructuralPatterns.Decorator.DecoratorNotifier
{
    internal static class DecoratorNotifierRunner
    {
        internal static void Run()
        {
            EmailNotifier emailNotifier = new();
            SMSNotifier smsNotifier = new();
            NotifiersDecorator notifiersDecorator = new();
            notifiersDecorator.AddToNotifiers(emailNotifier).AddToNotifiers(smsNotifier);
            notifiersDecorator.Notify();
        }
    }
}
