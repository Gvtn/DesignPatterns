using BehavioralPatterns.Command.CommandWithHistory;
using System;

namespace BehavioralPatterns.Command
{
    internal static class CommandUseExamples
    {
        public static void CommandWithHistoryRun()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("--> Command With History example");

            Canvas.Run();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('\n', 2));
        }
    }
}
