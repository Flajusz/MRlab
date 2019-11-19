using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {

        // napisz porgram wspomagający magazyn bibilioteki
        //kazda ksiazka ma tytul,magazyn ma 3 regaly 
        //regal
        //ma 6 polek,10 miejsc ,wskaz gdzie szukac ksiażki na podsstawie tytulu  
        static void Main(string[] args)
        {

            Ksiazka[,,] a = new Ksiazka[3, 6, 10];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(2); k++)
                    {
                        a[i, j, k] = new Ksiazka("Pan Tadeusz", "Mickiewicz", i, j, k);

                    }
                }

            }
            a[1, 4, 6] = new Ksiazka("Potop", "Sienkiewicz", 1, 4, 6);

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(2); k++)
                    {
                        Console.WriteLine("Regał[{0}],Półka[{1}],Miejsce[{2}]:", i, j, k);
                        Console.WriteLine(a[i, j, k].Tytul + " , " + a[i, j, k].Autor);

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("Czego szukasz ?");
            string kon = Convert.ToString(Console.ReadLine());
            int licznik = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (kon == a[i, j, k].Tytul || kon == a[i, j, k].Autor)
                        {
                            Console.WriteLine("Obiekt znajduje się w Regale {0}, Półce {1}, Miejscu {2}", i, j, k);
                            licznik++;

                        }



                    }
                }

            }
            if (licznik == 0)
            {
                Console.WriteLine("Nie znaleziono obiektu");
            }

            Console.ReadKey();


        }
    }
}

