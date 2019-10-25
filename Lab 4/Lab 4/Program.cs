﻿using System;

namespace Lab_4
{
    class Program
    {

             static string wczytajliczbe (string licznik)
        {
                 Console.WriteLine("Podaj  liczbę " + licznik + ": ");
                 string tekst = Console.ReadLine();
                 return  tekst;
        }

            static int dodaj (int liczba1, int liczba2 )
        {
                 int wynik=liczba1+liczba2;
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


        static int odejmij(int liczba1, int liczba2 )
        {
              int wynik=liczba1-liczba2;
              return wynik;
        }
            static int pomnoz(int liczba1, int liczba2 )
        {
                  int wynik=liczba1*liczba2;
                  return wynik;
        }
           static double podziel(int liczba1, int liczba2 ,out bool powodzenie)
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
           if(liczba2 == 0) 
            {
                throw new DivideByZeroException();
            }
           return (double) liczba1/liczba2;
        }
        


        static void Main(string[] args)
        {

           string tekst1 = wczytajliczbe("1");
           string tekst2 = wczytajliczbe("2");
            Console.WriteLine("Wybierz operacje");
            string operacja = Console.ReadLine();       
            int liczba1 = Convert.ToInt32(tekst1);
            int liczba2 = Convert.ToInt32(tekst2);
            double wynik;
            switch (operacja)
        {
                case "+":
                    wynik=dodaj(tekst1, tekst2);
                    Console.WriteLine(wynik);
                    break;
                case "-":
                    wynik=odejmij(liczba1, liczba2);
                    Console.WriteLine(wynik);
                    break;
                case "*":
                    wynik=pomnoz(liczba1, liczba2);
                    Console.WriteLine(wynik);
                    break;
                case "/":
                     wynik=podziel(liczba1, liczba2, out bool powodzenie );
                        if (powodzenie)
                          {
                        Console.WriteLine(wynik);

                         }
                     else
                       {
                        Console.WriteLine("podzielone prze 0");
                       }

                    try
                    {
                        Console.WriteLine(podziel2(liczba1, liczba2));

                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("podzielono przez 0");
                    }
                    break;

                default:
                    break;


        }


        }
    }
}
