﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Podaj Liczbe");
            string odpowiedz = Console.ReadLine();
            int liczba;
            bool sukces=int.TryParse(odpowiedz, out liczba);
            if(sukces){
                if (liczba % 2 == 0)
                {
                    Console.WriteLine("Parzyszta");

                }
                else {
                    Console.WriteLine("Nieparzysta");
                }
            }
            else { Console.WriteLine("Nie podano liczby"); }
            Console.ReadKey();
            */
         /*
         Console.WriteLine("Podaj Liczbe");
         string odpowiedz = Console.ReadLine();
         int liczba=Convert.ToInt32(odpowiedz);
        Console.WriteLine((liczba % 2 == 0) ? "Parzysta" : "Nieparzysta");

         Console.ReadKey();
         */
         /*
         double odleglosc = 1;
         double suma = 0;
         int licznik = 0;
         while (odleglosc != 0)
         {
             string odleglosctekst = Console.ReadLine();
             odleglosc = Convert.ToDouble(odleglosctekst);
             suma += odleglosc;
             licznik++;
         }
         double wynik = suma / (licznik -1) ;
         Console.WriteLine(wynik);
         */
         /*
         int licznik=1;
         string linia= Console.ReadLine();
         while (linia !="exit") {
             Console.WriteLine(licznik++);
             linia= Console.ReadLine();
             if (licznik == 5) {
                 Console.WriteLine("Wyprodukowano maksymalna ilość");
                 break;
             } 
             */
            int licznik = 1;
            int[] liczniki = {1, 1, 1};
            string linia = string.Empty;
            while (linia != "exit") {
              /*  Console.WriteLine(licznik++);*/
                linia = Console.ReadLine();
                switch (linia)
                {
                    case "A":
                        Console.WriteLine(liczniki[0]++);
                        licznik++;
                        break;
                    case "B":
                        Console.WriteLine(liczniki[1]++);
                        licznik++;
                        break;
                    case "C":
                        Console.WriteLine(liczniki[2]++);
                        licznik++;
                        break;
                    default:
                        Console.WriteLine("zly kod porduktu");
                        break;


                }
                if (licznik == 5) {
                    Console.WriteLine("Dość na dziś");
                    break;
                }

            }

             
            }

        }
    }

