using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Auto
    {
        private static int Iloscmodeli = 0;
        public readonly string Model;
        public int VIN { get; private set; }
        private int _waga;

        public string model;
        private int _przebieg;
        public int przebieg { get; private set; }
        public void zwiekszprzebieg(int dystans)
        {
            if (dystans < 0)
            {
                throw new ArgumentException("dystans nie możę być ujemny");
            }
            przebieg += dystans;
        }

        /* public int przebieg
         { get
             {
                 return _przebieg;
             }
             set
             {
                 if (value > przebieg)
                 {
                     _przebieg = value;
                 }
             }
         }*/



        public Auto(int przebieg, string model, int ilosc_drzwi, int Waga) : this()
        {
            this.przebieg = przebieg;
            this.model = model;
            this.ilosc_drzwi = ilosc_drzwi;
            waga = Waga;

        }
        private Auto()
        {
            VIN = Iloscmodeli++;
        }

        public Auto(int id)
        {

        }

        public Auto(int iloscdrzwi, int waga) : this(0, "Multipla", iloscdrzwi, waga)
        { }

        public int ilosc_drzwi { get; private set; }

        public int waga
        {
            get
            {
                return _waga;
            }
            set
            {
                _waga = value;
                if (_waga < 0)
                {
                    _waga = 0;
                }
            }
        }


    }
}
