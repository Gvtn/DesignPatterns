namespace CreationalPatterns.AbstractFactory.PaintingsShop
{
    internal abstract class Brush
    {
        public abstract void CheckBrush();
       
    }

    internal class GouacheBrush : Brush
    {
        public override void CheckBrush()
        {
            Console.WriteLine("Gouache brush");
        }
    }

    internal class AquarelBrush : Brush
    {
        public override void CheckBrush()
        {
            Console.WriteLine("Aquarel brush");
        }
    }
}
