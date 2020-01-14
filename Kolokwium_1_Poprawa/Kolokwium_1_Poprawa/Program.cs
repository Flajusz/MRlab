using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1_Poprawa
{
    class Program
    {

        public static double Zadanie1(int number)
        {
            int n = number;
            if (n == 0)
            {
                return 1.0;
            }
            else
                return (1.5 * (Zadanie1(n - 1))) - 1;
        }

        public static void Zadanie2()
        {
            Console.Write("Podaj liczbe: ");
            string linia = Console.ReadLine();
            int l;
            int.TryParse(linia, out l);

            int[] tab = new int[200];
            int liczba = 1;


            for (int i = 0; i < tab.GetLength(0); i++)
            {
                tab[i] = liczba++;
            }

            if (l == 0)
            {
                throw new DivideByZeroException();
            }

            else
            {
                for (int i = 0; i < tab.GetLength(0); i++)
                {
                    if (tab[i] % l == 0)
                    {
                        Console.WriteLine(tab[i]);
                    }
                }
            }
        }

        static void Zadanie3()
        {
            int[,] tab_1 = new int[4, 3];
            int[,] tab_2 = new int[3, 8];

            int max_wierszy = Math.Max(tab_1.GetLength(0), tab_2.GetLength(0));

            int max_kolummn = Math.Max(tab_1.GetLength(1), tab_2.GetLength(1));

            int[,] wynik = new int[max_wierszy, max_kolummn];

            for (int i = 0; i < tab_1.GetLength(0); i++)
            {
                for (int j = 0; j < tab_1.GetLength(1); j++)
                {
                    tab_1[i, j] = 1;
                    wynik[i, j] += tab_1[i, j];
                }
            }

            for (int i = 0; i < tab_2.GetLength(0); i++)
            {
                for (int j = 0; j < tab_2.GetLength(1); j++)
                {
                    tab_2[i, j] = 0;
                    wynik[i, j] += tab_2[i, j];
                }
            }

            for (int i = 0; i < max_wierszy; i++)
            {
                for (int j = 0; j < max_kolummn; j++)
                {
                    Console.Write(wynik[i, j]);
                }
                Console.WriteLine();
            }
        }

        static int[,] NewTable1()
        {
            int[,] tab1 = new int[3, 5];

            Random rnd = new Random();

            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    tab1[i, j] = rnd.Next(0, 100);
                    Console.Write(tab1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            return tab1;
        }

        static int[][] NewTable2()
        {
            Random rnd = new Random();

            int[][] tab2 = new int[rnd.Next(1, 10)][];

            for (int i = 0; i < tab2.Length; i++)
            {
                tab2[i] = new int[rnd.Next(1, 10)];
            }

            for (int i = 0; i < tab2.Length; i++)
            {
                for (int j = 0; j < tab2[i].Length; j++)
                {
                    tab2[i][j] = rnd.Next(0, 100);
                    Console.Write(tab2[i][j] + "\t");
                }
                Console.WriteLine();
            }

            return tab2;
        }


        static void Zadanie4(int[,] tabela)
        {

            int min = tabela[0,0];
            for (int i = 0; i < tabela.GetLength(0); i++)
            {
                for (int j = 0; j < tabela.GetLength(1); j++)
                {
                    if (tabela[i, j] < min)
                    {
                        min = tabela[i, j];
                    }
                }
            }

            Console.WriteLine("Najmniejszy element: " + min);
            Console.WriteLine();
        }

        static void Zadanie4(int[][] tabela)
        {

            int min = tabela[0][0];

            for (int i = 0; i < tabela.Length; i++)
            {
                for (int j = 0; j < tabela[i].Length; j++)
                {
                    if (tabela[i][j] < min)
                    {
                        min = tabela[i][j];
                    }
                }
            }

            Console.WriteLine("Najmniejszy element : " + min);
        }


        static void Main(string[] args)
        {
            Console.Write("Podaj numer zadania: ");
            string linia = Console.ReadLine();

            switch (linia)
            {

                case "1":

                    Console.Write("Podaj liczbe n: ");
                    if (int.TryParse(Console.ReadLine(), out int liczba))
                    {
                        Console.WriteLine(Zadanie1(liczba));
                    }
                    break;

                case "2":

                    try
                    {
                        Zadanie2();
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Nie można dzielić przez 0");
                    }
                    break;

                case "3":
                    Zadanie3();
                    break;

                case "4":
                    Console.WriteLine();
                    Zadanie4(NewTable1());
                    Zadanie4(NewTable2());
                    break;

                case "5":
                    //Zadanie5
                    EBook eBook = new EBook("Bolesław Prus", "Lalka", new DateTime(1890 / 1 / 1), new DateTime(2019 / 12 / 15), 25.55, 10);
                    break;

                default:
                    Console.WriteLine("Brak zadania o podanym numerze");
                    break;
            }

            Console.ReadKey();
        }
    }
}