using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Command.CommandWithHistory
{
    internal class DrawingCommand : ICommand
    {
        private ConsoleColor _consoleColor;
        private int _x, _y;

        public DrawingCommand(ConsoleColor consoleColor)
        {
            _consoleColor = consoleColor;
            _x = Console.CursorLeft;
            _y = Console.CursorTop;
        }
        public void Do()
        {
            Console.BackgroundColor = _consoleColor;
            Console.Write(" ");
        }

        public void Undo()
        {
            Console.ResetColor();
            Console.SetCursorPosition(_x, _y);
            Console.Write(" ");
        }
    }
}
