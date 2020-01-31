using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_1_II_Termin
{
    class KontoBankowe
    {
        private readonly string _imie;
        private readonly string _nazwisko;
        private readonly int _kod;
        private double _stan;

        

        public double uznanie(double kwota) 
        {
            return _stan + kwota;
        }
        public double obciazenie(double kwota) 
        {
            double przed = _stan;
            _stan = _stan-kwota;
            if (_stan < -100)
                Console.WriteLine("Nie można bardziej obciązyć konta");
            _stan = przed;
            return _stan;

        }

        public KontoBankowe(string imie, string nazwisko, int kod, double stan)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _kod = kod;
            _stan = stan;
        }


    }
   
      
}
