﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Lab_5
{
    class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJey display dimension : 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing.....");
        }
    }
}
