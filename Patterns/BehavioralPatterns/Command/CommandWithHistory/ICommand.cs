namespace BehavioralPatterns.Command.CommandWithHistory
{
    interface ICommand
    {
        void Do();
        void Undo();
    }
}
