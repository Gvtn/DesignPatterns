namespace CreationalPatterns.Singleton.ThreadSafeSingleton
{
    internal static class UserOfSingleton
    {
        internal static void Run()
        {
            List<Action> actions = new List<Action>()
            {
                ()=>CreateInstanceOfSingleton("one"),
                ()=>CreateInstanceOfSingleton("two"),
                ()=>CreateInstanceOfSingleton("three"),
                ()=>CreateInstanceOfSingleton("four"),
                ()=>CreateInstanceOfSingleton("five"),
            };
            Parallel.ForEach( actions, (a)=> a.Invoke());
        }

        private static void CreateInstanceOfSingleton(string name)
        {
            Console.WriteLine($"---> trying to craete singleton with name {name}");
            var singleton = Singleton.GetSingleton(name);
            Console.WriteLine($"        ! singleton instance name is {singleton.InstanceName} !");
            
        }
    }
}
