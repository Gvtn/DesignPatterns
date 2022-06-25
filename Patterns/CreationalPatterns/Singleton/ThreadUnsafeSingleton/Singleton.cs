namespace CreationalPatterns.Singleton.ThreadUnsafeSingleton
{
    internal class Singleton
    {
        private Singleton(string name) { InstanceName = name; }
        private static Singleton _instance;
        public readonly string InstanceName;

        public static Singleton GetInstance ( string name)
        {
            if(_instance == null)
            {
                _instance = new Singleton(name);
            }
            return _instance;
        }
    }
}
