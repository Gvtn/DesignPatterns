using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Command.CommandWithHistory
{
    internal static class Canvas
    {
        public static void Run()
        {
            var stack = new Stack<ICommand>();
            Console.WriteLine("Type 1,2,3... to drow colored block");
            Console.WriteLine("Type backspace (\\b) to undo");
            Console.WriteLine("Type enter to go to new line");
            Console.WriteLine("Type esc to stop this example");
            Console.CursorVisible = false;
            ICommand command;
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                switch (input)
                {
                    case '\b':
                        if (stack.TryPop(out var c))
                            c.Undo();
                        break;
                    case '\r':
                    case '\n':
                        command = new NewLineCommand();
                        command.Do();
                        stack.Push(command);
                        break;
                    case '\u001b':
                        Console.WriteLine("--> stopping...");
                        Console.ResetColor();
                        Console.CursorVisible = true;
                        return;
                    default:

                        try
                        {
                            command = new DrawingCommand((ConsoleColor)int.Parse(input.ToString()));
                        }
                        catch { break; }
                        command.Do();
                        stack.Push(command);
                        break;
                }
            }
        }
    }
}