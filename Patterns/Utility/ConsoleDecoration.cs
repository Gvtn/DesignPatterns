using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class ConsoleDecoration
    {
        public static void AddDecoration(string message, Action action)
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"--> {message}");

            action();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('\n', 2));
        }
    }
}
