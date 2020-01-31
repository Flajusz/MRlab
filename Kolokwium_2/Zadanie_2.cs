using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    class Exten
    {
        public string Cenowka_float(float liczba)
        {
            decimal liczba_1 = (decimal)liczba;
            string nowy = liczba_1.ToString();
            return nowy;

        }

        public string Cenowka_double(double liczba)
        {
            decimal liczba_1 = (decimal)liczba;
            string nowy = liczba_1.ToString();
            return nowy;
        }


    }
}
namespace Kolokwium_2
{
    class Zadanie_2
    {
    }
}
