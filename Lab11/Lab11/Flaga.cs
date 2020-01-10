using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    [Flags]
    enum TypOsoby
    {
        Brak=0,
        Dziecko=1,//[0001]
        Młodzież=2,//[0010]
        Dorosly=4,//[0100]
        Starszy=8//[1000]

    }
    
    [Flags]
    enum Zainteresowania
    {
        Elektronika,
        Motoryzacja,
        Gaming,
        Gotowanie


    }
}
