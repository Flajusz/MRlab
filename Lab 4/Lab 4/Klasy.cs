using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    class Kalkulator
    {
        static string wczytajliczbe(string licznik)
        {
            Console.WriteLine("Podaj  liczbę " + licznik + ": ");
            string tekst = Console.ReadLine();
            return tekst;
        }

        static int dodaj(int liczba1, int liczba2)
        {
            int wynik = liczba1 + liczba2;
            return wynik;

        }
        static int dodaj(int liczba1, int liczba2, int liczba3)
        {
            return dodaj(dodaj(liczba1, liczba2), liczba3);
        }
        static int dodaj(string tekst1, string tekst2)
        {
            int liczba1 = Convert.ToInt32(tekst1);
            int liczba2 = Convert.ToInt32(tekst2);
            return liczba1 + liczba2;
        }


        static int odejmij(int liczba1, int liczba2)
        {
            int wynik = liczba1 - liczba2;
            return wynik;
        }
        static int pomnoz(int liczba1, int liczba2)
        {
            int wynik = liczba1 * liczba2;
            return wynik;
        }
        static double podziel(int liczba1, int liczba2, out bool powodzenie)
        {
            if (liczba2 == 0)
            {
                powodzenie = false;
                return 0;
            }
            powodzenie = true;
            double wynik = liczba1 / liczba2;
            return wynik;
        }

        static double podziel2(int liczba1, int liczba2)
        {
            if (liczba2 == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)liczba1 / liczba2;
        }
    }
}
