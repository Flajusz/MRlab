using System;


namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int liczba = Convert.ToInt32(Console.ReadLine());
            (int wynik,int reszta) = liczba.Podziel(3);
            Console.WriteLine($"{liczba}/3={wynik} reszta{reszta}");
            */


            //string text = "kajskasaksasa";
            //Console.WriteLine(text.Ilosc('a'));
            //Console.WriteLine(text.Ilosc());
            //Console.WriteLine(text.Ilosc('a', true));

            Reklama reklama = new Reklama("Kup Teraz", TypOsoby.Dorosly| TypOsoby.Młodzież| TypOsoby.Starszy, Zainteresowania.Gaming);
            



        }

      
        
    }
}
