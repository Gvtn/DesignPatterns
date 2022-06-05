namespace StructuralPatterns.Adapter
{
    internal class Guitar : IGuitar
    {
        public void PlayGuitar()
        {
            Console.WriteLine("Playing guitar");
        }
    }
}
