using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_2
{
    public class Kierowca
    {
        [Flags]
        public enum Uprawnienia
        {
            brak,
            Kat_A,
            Kat_B,
            Kat_C,
            Kat_D
        }

        public string nazwisko;
        public DateTime DatawaznosciOC;
        public Uprawnienia uprawnienia;

        public Kierowca(string nazwisko, DateTime datawaznosciOC, Uprawnienia uprawnienia)
        {
            this.nazwisko = nazwisko;
            DatawaznosciOC = datawaznosciOC;
            this.uprawnienia = uprawnienia;
        }
    }

   public class Zadanie_4
    {

        Kierowca Ziutek = new Kierowca("Kowalski", DateTime.Now.AddDays(20),Kierowca.Uprawnienia.Kat_C | Kierowca.Uprawnienia.Kat_B);
        Kierowca Mietek = new Kierowca("Nowak", DateTime.Now.AddMonths(2), Kierowca.Uprawnienia.Kat_B);
        
        

        

    }
}
