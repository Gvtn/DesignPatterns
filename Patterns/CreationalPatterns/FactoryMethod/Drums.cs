namespace CreationalPatterns.FactoryMethod
{
    internal class Drums : MusicalInstrument
    {
        public override void MakeSound()
        {
            Console.WriteLine("Sound of Drums");
        }
    }
}
