namespace CreationalPatterns.FactoryMethod
{
    public static class FactoryMethodUseExamples
    {
        public static void FactoryMethodRun()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("--> Factory Method example");
          
            CreateInstrumentAndMakeSound(new DrumsFactory());
            CreateInstrumentAndMakeSound(new HornFactory());

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('\n', 2));
        }

        private static void CreateInstrumentAndMakeSound(MusicalInstrumentFactory instrumentFactory)
        {
            var instrument = instrumentFactory.CreateMusicalInstrument();
            instrument.MakeSound();
        }
    }
}
