using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Strona
    {

        //Dowolne rozszerzanie klasy, hermetyzacja wszystkiego co mozliwe
        //Strona internetowa
        //  Serwer
        //      Szybkosc Procesora
        //      Łącze
        //      RAM
        //      Technologia
        //  Domena
        //      Nazwa
        //      Waznosc
    }

    class Serwer
    {
        public int SzybProcesora { get; private set; }
        public int Lacze { get; private set; }
        public int Ram { get; private set; }
        public string Technologia { get; private set; }

        public Serwer(int szybproc, int lacze, int ram, string technologia)
        {
            SzybProcesora = szybproc;
            Lacze = lacze;
            Ram = ram;
            Technologia = technologia;
        }
    }

    class Domena
    {

        public int Nazwa { get; private set; }
        public DateTime Waznosc { get; private set; }

        public Domena(int nazwa, DateTime waznosc)
        {
            Nazwa = nazwa;
            Waznosc = waznosc;
        }
    }
}
