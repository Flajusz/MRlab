﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
    class PaperJammedEventArgs : PrinterEventArgs
    {
        public PaperJammedEventArgs(int page) : base(page)
        {

        }

    }
}
