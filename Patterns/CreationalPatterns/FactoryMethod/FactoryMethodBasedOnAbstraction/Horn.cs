namespace CreationalPatterns.FactoryMethod
{
    internal class Horn : MusicalInstrument
    {
        public override void MakeSound()
        {
            Console.WriteLine("Sound of Horn");
        }
    }
}
