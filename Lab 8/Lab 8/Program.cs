using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Lab_8
{
    class Program
    {
        public class osoba
        {
            public int id;
            public string imie;
            public string nazwisko;
        }
  
        static void Main(string[] args)
        {
            List<int> lista = Enumerable.Range(100, 150).ToList();
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
            List<string> nazwiska = osoby.Select(x => x.nazwisko).ToList();
            List<string> unikalne_nazwiska = osoby.Select(x => x.nazwisko).Distinct().ToList();

            foreach (var item in unikalne_nazwiska)
            {
                Console.WriteLine(item);
            }

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

