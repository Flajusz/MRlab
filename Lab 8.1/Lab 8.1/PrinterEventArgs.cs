using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._1
{
    public abstract class PrinterEventArgs : EventArgs
    {
        public int Page { get; private set; }
        public PrinterEventArgs(int page)
        {
            Page = page;
        }

    }
}
