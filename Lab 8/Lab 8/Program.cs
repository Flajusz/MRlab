﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;


namespace Lab_8
{
    class Program
    {
        public class osoba
        {
            public int id;
            public string imie;
            public string nazwisko;

            public osoba(int id, string imie, string nazwisko)
            {
                this.id = id;
                this.imie = imie;
                this.nazwisko = nazwisko;
            }

          
        }

  
        static void Main(string[] args)
        {
            var NameGen = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var LastNameGen = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());
            List<osoba> lista = Enumerable.Range(100, 150)
                .Select(x =>
                new osoba(
                    x,
                    NameGen.Generate()
                    ,LastNameGen.Generate()
                    )
                ).ToList();

            List<osoba> posortowane = lista.OrderBy(x=>x.nazwisko).ThenBy(x=>x.imie).ToList();

            foreach (var item in posortowane)
            {
                Console.WriteLine($"{item.id} {item.imie} {item.nazwisko}");
                

            }








            /*
            List<int> podzielnie_na_3 = lista.Where(x => x % 3 == 0).ToList();
            double srednia = podzielnie_na_3.Average();
            double suma = podzielnie_na_3.Sum();

            List<osoba> osoby = lista.Select(
                x => new osoba()
                {
                    id = x,
                    imie=x.ToString(),
                    nazwisko="AAAA"

                }
                ).ToList();
            osoby[45].nazwisko = "ABC";
            osoba szukana = osoby.Where(x => x.nazwisko == "AAAA").First();
            Console.WriteLine($"{szukana.id} {szukana.imie} {szukana.nazwisko}");

            */

         //   List<string> nazwiska = osoby.Select(x => x.nazwisko).ToList();
         //   List<string> unikalne_nazwiska = osoby.Select(x => x.nazwisko).Distinct().ToList();

           /* foreach (var item in osoby)
            {
                Console.WriteLine(item);
            }*/

           /* int nr_strony = 2;
            int element = 10;
            var strona = lista.Skip(element * nr_strony - 1).Take(element);
            foreach (var item in strona)
            {
                Console.WriteLine(item);
            }*/

        //    foreach (var item in podzielnie_na_3)
        //    {
        //        Console.WriteLine(item);
        //    }

           // Console.WriteLine("Srednia to: " + srednia);
           // Console.WriteLine("Suma to: " + suma);



        }
       

            
        }
    }

