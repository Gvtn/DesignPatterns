using CreationalPatterns.FactoryMethod.FactoryMethodBasedOnAbstraction;

namespace CreationalPatterns.FactoryMethod
{
    public static class FactoryMethodUseExamples
    {
        public static void FactoryMethodBasedOnAbstractionRun()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("--> Factory Method Based On Abstraction example");


            var musicalInstrument = Factory.CreateMusicalInstrument(new DrumsFactory());
            musicalInstrument.MakeSound();
            musicalInstrument =  Factory.CreateMusicalInstrument(new HornFactory());
            musicalInstrument.MakeSound();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('\n', 2));
        }
    }
}
