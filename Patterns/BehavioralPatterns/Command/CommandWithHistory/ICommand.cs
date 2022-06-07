﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Command.CommandWithHistory
{
    interface ICommand
    {
        void Do();
        void Undo();
    }
}