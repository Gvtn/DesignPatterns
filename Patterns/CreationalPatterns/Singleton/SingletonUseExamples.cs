using CreationalPatterns.Singleton.ThreadUnsafeSingleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Singleton
{
    internal static class SingletonUseExamples
    {
        internal static void ThreadUnsafeSingletonExampleRun()
        {
            UserOfSingleton.Run();
        }
    }
}
