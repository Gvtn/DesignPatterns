namespace StructuralPatterns.Adapter
{
    public static class AdapterUseExamples
    {
        public static void AdapterOfObjectRun()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("--> Adapter Of Object example");

            var bassPlayer = new Bass(new Guitar());
            bassPlayer.PlayGuitar();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('\n', 2));
        }
    }
}
