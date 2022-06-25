using CreationalPatterns.Singleton.ThreadUnsafeSingleton;

namespace CreationalPatterns.Singleton
{
    internal static class SingletonUseExamples
    {
        internal static void ThreadUnsafeSingletonExampleRun()
        {
            UserOfSingleton.Run();
        }
        internal static void ThreadSafeSingletonExampleRun()
        {
            CreationalPatterns.Singleton.ThreadSafeSingleton.UserOfSingleton.Run();
        }
    }
}
