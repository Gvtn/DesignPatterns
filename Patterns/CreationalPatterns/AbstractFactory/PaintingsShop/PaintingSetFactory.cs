namespace CreationalPatterns.AbstractFactory.PaintingsShop
{
    internal abstract class PaintingSetFactory : IPaintingSet
    {
        public abstract Brush GetBrush();

        public abstract Paint GetPaint();
        
    }

    internal class AquarelSetFactory : PaintingSetFactory
    {
        public override Brush GetBrush()
        {
            return new AquarelBrush();
        }

        public override Paint GetPaint()
        {
            return new Aquarel();
        }
    }

    internal class GouacheSetFactory : PaintingSetFactory
    {
        public override Brush GetBrush()
        {
            return new GouacheBrush();
        }

        public override Paint GetPaint()
        {
            return new Gouache();
        }
    }
}