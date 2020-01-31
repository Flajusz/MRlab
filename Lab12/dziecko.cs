using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12
{
    class Dziecko
    {
      

        public double znizka { get; set; }
        public DateTime Data_UR { get; set; }
        


        public void ktora_klasa(out int wiek)
        {
            wiek = DateTime.Now.Year - Data_UR.Year;
            if (wiek < 7) Console.WriteLine("Dziecko nie chodzi do szkoly");
            else if (wiek >= 7 && wiek < 15) Console.WriteLine("Dziecko chodzi do podstawówki");
            else if (wiek >= 15 && wiek <= 19) Console.WriteLine("Dziecko chodzi do szkoły średniej");
            else Console.WriteLine("To nie jest dziecko");

        } 
    }
}
