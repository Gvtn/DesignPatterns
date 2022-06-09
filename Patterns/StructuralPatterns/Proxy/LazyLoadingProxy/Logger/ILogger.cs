namespace StructuralPatterns.Proxy.LazyLoadingProxy
{
    interface ILogger
    {
        void Log(string message, Action action);
        void Log(string message);
    }
}
