using System;

namespace Lab_4
{
    class komputer
    {
        public double predkosc;
        public int ram;
        public double dysk;
        public string id= "Dell" ;

        public void opisz()
        {
            Console.WriteLine(id +" " + predkosc + "GHz" +" " + ram +"GB"+" " +dysk + "GB HDD ");
        }
    }
   
    class Program
    {

       
        


        static void Main(string[] args)
        {

            komputer komputer_I = new komputer();
            komputer_I.predkosc=3.5;
            komputer_I.ram = 8;
            komputer_I.dysk = 1000;

            komputer komputer_II = new komputer();
            komputer_II.predkosc = 4;
            komputer_II.ram = 16;
            komputer_II.dysk = 4000;

            komputer_I.opisz();
            komputer_II.opisz();


            /*
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
       */

        }
    }
}
