namespace StructuralPatterns.Bridge.BridgeNameFormatter
{
    internal static class NameFormatterRunner
    {
        internal static void Run()
        {
            
            Console.WriteLine("Enter your first name");
            string firstName  = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Do you want fancy formatting? y/n");
            while(true)
            {
                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.Y:
                        Console.WriteLine("--> Applying fancy formatting:");
                        ApllyChosenFormatting(firstName, lastName, new FancyFormatting());
                        return;
                    case ConsoleKey.N:
                        ApllyChosenFormatting(firstName, lastName, new LowercaseFormatting());
                        return;
                }
            }
        }

        private static void ApllyChosenFormatting(string firstName, string lastName, IFormattingType formattingType)
        {
            NameFormatter nameFormatter = new NameFormatter(firstName, lastName);
            nameFormatter.FormattingType = new FancyFormatting();
            nameFormatter.FormatName();
        }
    }
}
