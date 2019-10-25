using System;

namespace Lab_4
{
    class Program
    {

                    static string wczytajliczbe (string licznik){
             Console.WriteLine("Podaj  liczbę");
            string tekst = Console.ReadLine();
            return  tekst;
            }

        static int dodaj (int liczba1, int liczba2 ){
           int wynik=liczba1+liczba2;
            return wynik;

                }
        static int odejmij(int liczba1, int liczba2 )    {
        int wynik=liczba1-liczba2;
            return wynik;
}
               static int pomnoz(int liczba1, int liczba2 ,)    {
         int wynik=liczba1*liczba2;
            return wynik;
}
               static int podziel(int liczba1, int liczba2 )    {
        int wynik=liczba1/liczba2;
            return wynik;
}
        static void Main(string[] args)
        {


           string tekst1 = wczytajliczbe("1");
           string tekst2 = wczytajliczbe("2");
            string operacja = Console.ReadLine();
            Console.WriteLine("Wybierz operacje");
            int liczba1 = Convert.ToInt32(tekst1);
            int liczba2 = Convert.ToInt32(tekst2);
            int wynik;
            switch (operacja) {
                case "+":
                    wynik=dodaj(liczba1, liczba2);
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
                     wynik=podziel(liczba1, liczba2);
                    Console.WriteLine(wynik);
                    break;
                default:
                    break;


            }


        }
    }
}
