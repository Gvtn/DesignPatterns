namespace CreationalPatterns.AbstractFactory.PaintingsShop
{
    internal abstract class Paint
    {
        public abstract void CheckPaint();
    }

    internal class Gouache : Paint
    {
        public override void CheckPaint()
        {
            Console.WriteLine("Gouache paint");
        }
    }
    internal class Aquarel : Paint
    {
        public override void CheckPaint()
        {
            Console.WriteLine("Aquarel paint");
        }
    }
}
