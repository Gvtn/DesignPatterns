using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Singleton.ThreadUnsafeSingleton
{
    internal static class UserOfSingleton
    {
        public static void Run()
        {
            Task[] tasks = new Task[]
            {
                Task.Run( async () => { await CreateSingleton("instance 1"); }),
                Task.Run( async () => { await CreateSingleton("instance 2"); }),
                Task.Run( async () => { await CreateSingleton("instance 3"); }),
                Task.Run( async () => { await CreateSingleton("instance 4"); }),

            };
            Task.WhenAll(tasks);
            Thread.Sleep(100);
        }

        private static async Task CreateSingleton(string instanceName)
        {
            Console.WriteLine($"---> trying to craete singleton with name {instanceName}");
            var singleton = Singleton.GetInstance(instanceName);
            Console.WriteLine($"        ! singleton instance name is {singleton.InstanceName} !");
        }
    }
}
