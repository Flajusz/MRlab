using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_1
{
    class Ebook
    {
        public string autor;
        public string tytul;
        public DateTime Data_wydania;
        public double cena;
        public double obnizka;

        public Ebook(string autor, string tytul, DateTime data_wydania, double cena, double obnizka)
        {
            this.autor = autor;
            this.tytul = tytul;
            Data_wydania = data_wydania;
            this.cena = cena;
            this.obnizka = obnizka;
        }
    }
}
