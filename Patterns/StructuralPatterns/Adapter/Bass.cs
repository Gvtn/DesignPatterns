namespace StructuralPatterns.Adapter
{
    internal class Bass : IGuitar
    {
        private readonly Guitar _guitar;

        public Bass(Guitar guitar)
        {
            _guitar = guitar;
        }
        public void PlayGuitar()
        {
            Console.WriteLine("Took guitar and playing like a bass");
            _guitar.PlayGuitar();
        }
    }
}
