namespace CreationalPatterns.Singleton.ThreadSafeSingleton
{
    internal class Singleton
    {
        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>( ()=> new Singleton(_name));

        private static string _name;
        public readonly string InstanceName;
        private Singleton(string name) {
            InstanceName = name;
        }
        static Singleton() { }
        public static Singleton GetSingleton(string name)
        {
            _name = name;
            return _instance.Value;
        }
    }
}
