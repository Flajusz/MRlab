using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Ksiazka
    {
        public string Tytul;
        public string Autor;
        public int Regal;
        public int Polka;
        public int Miejsce;



        public Ksiazka(string tytul, string autor, int regal, int polka, int miejsce)
        {
            Tytul = tytul;
            Autor = autor;
            Regal = regal;
            Polka = polka;
            Miejsce = miejsce;
        }

        public Ksiazka() { }
    }
}
