using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Command.CommandWithHistory
{
    internal class NewLineCommand : ICommand
    {
        private ConsoleColor _consoleColor;
        private int _x, _y;

        public NewLineCommand()
        {
            
        }
        public void Do()
        {
            Console.ResetColor();
            _x = Console.CursorLeft;
            _y = Console.CursorTop;
            Console.WriteLine();
        }

        public void Undo()
        {
            Console.ResetColor();
            Console.SetCursorPosition(_x, _y);
        }
    }
}
