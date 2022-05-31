namespace StructuralPatterns.Adapter
{
    public static class AdapterExamples
    {
        public static void AdapterExampleRun()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("--> Factory Method example");

            var bassPlayer = new Bass(new Guitar());
            bassPlayer.PlayGuitar();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('\n', 2));
        }
    }
}
