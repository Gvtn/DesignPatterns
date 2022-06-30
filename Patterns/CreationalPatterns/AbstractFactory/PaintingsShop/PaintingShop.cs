using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory.PaintingsShop
{
    internal static class PaintingShop
    {
        internal static void Run()
        {
            Console.WriteLine("Creating Aquarel Brush");
            PaintingSetFactory factory = new AquarelSetFactory();
            GetBrushFromFactory(factory).CheckBrush();
            Console.WriteLine("Creating Gouache Paint");
            factory = new GouacheSetFactory();
            GetPaintFromFactory(factory).CheckPaint();
        }

        private static Brush GetBrushFromFactory(PaintingSetFactory factory)
        {
            return factory.GetBrush();
        }

        private static Paint GetPaintFromFactory(PaintingSetFactory factory)
        {
            return factory.GetPaint();
        }
    }
}
