namespace CreationalPatterns.FactoryMethod
{
    internal abstract class MusicalInstrumentFactory
    {
        public abstract MusicalInstrument CreateMusicalInstrument();
    }

    internal class HornFactory : MusicalInstrumentFactory
    {
        public override MusicalInstrument CreateMusicalInstrument()
        {
            return new Horn();
        }
    }

    internal class DrumsFactory : MusicalInstrumentFactory
    {
        public override MusicalInstrument CreateMusicalInstrument()
        {
            return new Drums();
        }
    }
}
