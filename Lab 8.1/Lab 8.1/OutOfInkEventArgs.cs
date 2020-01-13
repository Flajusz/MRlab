using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._1
{
    class OutOfInkEventArgs
    {
        public class OutOfInkEventArgs : PrinterEventArgs
        {

            public OutOfInkEventArgs(string inkColor, int page) : base(page)
            {
                this.InkColor = inkColor;
            }

            public string InkColor { get; set; }

        }

    }
}
