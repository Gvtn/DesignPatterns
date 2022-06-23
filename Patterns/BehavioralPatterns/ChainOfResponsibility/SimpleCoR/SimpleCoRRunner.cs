using BehavioralPatterns.ChainOfResponsibility.SimpleCoR.NotebookDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR
{
    internal static class SimpleCoRRunner
    {
        private static List<Laptop> _laptops = new List<Laptop>
        {
            new LaptopBuilder()
            .AddMotherboard(new Motherboard() {Series = "dell mega super motherboard", BreakageSeverity = BreakageSeverity.Critical})
            .AddGraphicsCard(new GraphicsCard(){Series = "NVIDIA GeFOrce RTX 3080 laptop", BreakageSeverity= BreakageSeverity.Critical})
            .AddScreen(new Screen(){Series = "3840x2160 UHD (4K)", BreakageSeverity= BreakageSeverity.Critical})
            .AddKeyboard(new Keyboard() {Series = "mega shiny led super keyboard", BreakageSeverity = BreakageSeverity.Critical })
            .Build(),

            new LaptopBuilder()
            .AddScreen(new Screen(){Series = "default", BreakageSeverity= BreakageSeverity.Light})
            .AddKeyboard(new Keyboard() {Series = "stock keyboard", BreakageSeverity = BreakageSeverity.Medium })
            .Build(),

            new LaptopBuilder()
            .AddScreen(new Screen(){Series = "13.3\" OLED (1920x1080) Full HD", BreakageSeverity= BreakageSeverity.Medium})
            .AddKeyboard(new Keyboard() {Series = "simple led keyboard", BreakageSeverity = BreakageSeverity.Medium })
            .AddGraphicsCard(new GraphicsCard(){Series = "NVIDIA GeFOrce 1040", BreakageSeverity= BreakageSeverity.Light})
            .Build()
        };

        internal static void Run()
        {
            var laptop = _laptops[new Random().Next(0, 3)];
            int counter = 1;
            Console.CursorVisible = false;
            while (laptop.IsNotWorkingLaptop)
            {
                Console.WriteLine($"Trying to repair laptop in {counter} service center");
                var serviceCenter = new LaptopRepairService();
                serviceCenter.ViewListOfSpecialists();
                var sb = new StringBuilder();
                if (laptop.Keyboard.IsNotWorking)
                    sb.Append($"Keyboard breakage level {laptop.Keyboard.BreakageSeverity} || ");
                if (laptop.Screen.IsNotWorking)
                    sb.Append($"Screen breakage level {laptop.Screen.BreakageSeverity} || ");
                if (laptop.Motherboard.IsNotWorking)
                    sb.Append($"Motherboard breakage level {laptop.Motherboard.BreakageSeverity} || ");
                if (laptop?.GraphicsCard != null  && laptop.GraphicsCard.IsNotWorking)
                    sb.Append($"GraphicsCard breakage level {laptop.GraphicsCard.BreakageSeverity}");
                Console.WriteLine($"Currently not working: {sb}");
                Task.Run(() => LoadingImitation()).Wait();
                
                serviceCenter.RepairLaptop(laptop);
                Console.WriteLine();
                counter++;
            }

            Console.CursorVisible = true;
            Console.WriteLine("Laptop successfully repaired");
        }

        private static void LoadingImitation()
        {
            for(int i = 0; i < new Random().Next(3,5); i++)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', 20));
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write("Repairing.");
                Thread.Sleep(200);
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write("Repairing..");
                Thread.Sleep(200);
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write("Repairing...");
                Thread.Sleep(200);
            }
            Console.WriteLine();
        }
    }
}