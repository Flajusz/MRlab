using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Reklama
    {
        public string tresc;
        private TypOsoby TypOsoby;
        private Zainteresowania Zainteresowania;

        public void Test()
        {
            if (TypOsoby.HasFlag(TypOsoby.Dziecko))
            {
                Console.WriteLine("Reklama dla dzieci");
            }
            if (TypOsoby < TypOsoby.Dorosly)
            {
                Console.WriteLine("Reklama dla niepelnoletnich");
            }

            /*
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(TypOsoby);
            }
            */

            for (int i = 0; i <= TypOsoby.Brak.SumaTypowOsob(); i++)
            {
                Console.WriteLine((TypOsoby)i);
            }

            
        }

        public Reklama(string tresc, TypOsoby typOsoby, Zainteresowania zainteresowania)
        {
            this.tresc = tresc;
            TypOsoby = typOsoby;
            Zainteresowania = zainteresowania;
        }
    }
}
