using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab11
{
    static class Extension
    {
        public static (int, int) Podziel(this int dzielna, int dzielnik)
        {
            return (dzielna / dzielnik, dzielna%dzielnik);
        }

        public static int Ilosc(this string tekst,char szukana)
        {
            return tekst.Where(x => x.Equals(szukana)).Count();
        }
        public static int Ilosc(this string tekst)
        {
            return tekst.Length;
        }

        public static int Ilosc(this string tekst, char szukana_1, bool check = true)
        {
            if (tekst.Length == 0) check = false;
            if (check)
            {
                tekst=tekst.ToUpper();
                szukana_1 = char.ToUpper(szukana_1);
            }

            return tekst.Ilosc(szukana_1);        
            
        }

        public static int SumaTypowOsob(this TypOsoby typ)
        {

            return Enum.GetValues(typeof(TypOsoby)).Cast<TypOsoby>().Sum(x => (int)x);
        }

    }
}
