namespace StructuralPatterns.Proxy.LazyLoadingProxy
{
    internal class Logger : ILogger
    {
        public void Log(string message, Action action)
        {
            Console.WriteLine($"Action started: {message}");
            action();
            Console.WriteLine($"Action ended: {message}");
        }
        public void Log(string message)
        {
            Console.WriteLine($"Message for log: {message}");
        }
    }
}
