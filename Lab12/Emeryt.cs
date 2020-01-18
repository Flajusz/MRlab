using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12
{
    class Emeryt
    {
        public string Nrlegitymacji { get; set; }
        public bool Zwolnienie { get; set; } 
        public DateTime Data_Urodzenia { get; set; }
        public string Adres_Zdjecia { get; set; }

        public (string legitka, bool zwolnienie, DateTime data_ur , string adres_zdj) Zwroc_Dane()
        {
            return (Nrlegitymacji , Zwolnienie, Data_Urodzenia, Adres_Zdjecia);
        }
        public void Deconstruct(out string nrLegitymacji,out bool zwolnienie,out DateTime data_urodzenia,out string zdjecie)
        {
            nrLegitymacji = Nrlegitymacji;
            zwolnienie = Zwolnienie;
            data_urodzenia = Data_Urodzenia;
            zdjecie = Adres_Zdjecia;


        }

        public void Deconstruct(out string nrLegitymacji,out string zdjecie)
        {
            nrLegitymacji = Nrlegitymacji;
            zdjecie = Adres_Zdjecia;
        }

    }
}
