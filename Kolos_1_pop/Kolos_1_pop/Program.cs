using System;

namespace Kolos_1_pop
{
    class Program
    {
        public static void zadanie_1(double x, double y)
        {
            double wynik = Math.Pow(x, 2) + Math.Pow(y, 2);
            bool czy_jest = true;
            if (wynik > 1) czy_jest = false;
            Console.WriteLine(czy_jest);

        }

        public static void zadanie_2(int[] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {



            }

        }

        public static void zadanie_3(int[,] tab)
        {
            int gora = 0;
            int dol = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (j > i) gora = gora + tab[i, j];
                    else if (i > j) dol = dol + tab[i, j];

                }
            }
            Console.WriteLine(gora);
            Console.WriteLine(dol);
            if (gora > dol) Console.WriteLine("Wieksza suma na gorze");
            else if (gora < dol) Console.WriteLine("Wieksza suma na dole");
            else if (gora == dol) Console.WriteLine("obie sumy sa równe");



        }

        public static void zadanie_5(int[,] tab, bool ktory, int miejsce, int rozmiar)
        {


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer zadania");
            int wybor = Convert.ToInt32(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    Console.WriteLine("Podaj x");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Podaj y");
                    double y = Convert.ToDouble(Console.ReadLine());
                    zadanie_1(x, y);
                    break;
                case 2:
                    int[] tab = new int[10] { 2, 4, 1, 4, 6, 2, 4, 4, 1, 4, };
                    zadanie_2(tab);
                    break;
                case 3:
                    int[,] tab1 = new int[3, 3];
                    for (int i = 0; i < tab1.GetLength(0); i++)
                    {
                        for (int j = 0; j < tab1.GetLength(1); j++)
                        {
                            tab1[i, j] = 1;


                        }
                    }
                    tab1[0, 2] = 3;
                    zadanie_3(tab1);
                    break;

            }


        }
    }
}
