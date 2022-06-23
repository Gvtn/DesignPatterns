using BehavioralPatterns.ChainOfResponsibility.SimpleCoR.NotebookDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility.SimpleCoR
{
    internal class Laptop
    {
        public Screen Screen { get; set; }
        public Keyboard Keyboard { get; set; }
        public Motherboard Motherboard { get; set; }
        public GraphicsCard GraphicsCard { get; set; }

        public bool IsWorkingLaptop => Screen.IsWorking && Keyboard.IsWorking && Motherboard.IsWorking && (GraphicsCard == null || GraphicsCard.IsWorking);
        public bool IsNotWorkingLaptop => !IsWorkingLaptop;
    }
}
