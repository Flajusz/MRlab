using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_1
{
    class Program
    {
        static void Zad_1()
        {
            double[] n = new double[15];
            n[0] = 1;

            for (int i = 1; i < n.GetLength(0); i++)
            {
                n[i] = (1.5 * (n[i - 1])) - 1;
            }

            for (int i = 0; i < n.GetLength(0); i++)
            {
                Console.Write("W" + i + ":" + n[i] + " ");
            }
        }



        static void Zad_2()
        {
            double[] n = new double[200];
            double k = 0;

            for (int i = 0; i < n.GetLength(0); i++)
            {
                k++;
                n[i] = k;
            }
            Console.WriteLine("Podaj dzielnik");
            int d = Convert.ToInt32(Console.ReadLine());
            if (d == 0)
            {
                Console.WriteLine("nie dziel przez 0");
            }
            else
            {
                for (int i = 0; i < n.GetLength(0); i++)
                {
                    n[i] = n[i] / d;
                }
                for (int i = 0; i < n.GetLength(0); i++)
                {
                    Console.Write("W" + i + ":" + n[i] + " ");
                }

            }


        }
        /* void zad_3()
        {
            int[,] a = new int[4, 3]
            {
                {2,3,1},
                {1,2,1},
                {2,3,1},
                {1,2,1}
            };
            int[,] b = new int[2, 4]
            {
                {1,3,3,4 },
                {2,2,4,1 }
            };
            
           
            
        }

        static int[,] zad_3_dlc(int [,]a,int [,] b)
        {
            int[,] f;

            if (a.GetLength(0) > b.GetLength(0))
                
            {
                if (a.GetLength(1) > b.GetLength(1))
                {
                    int[,] f = new int[a.GetLength(0), a.GetLength(1)];
                }
                else
                {
                    int[,] f = new int[a.GetLength(0), b.GetLength(1)];
                }
            }
            else
            {
                if (a.GetLength(1) > b.GetLength(1))
                {
                    int[,] f = new int[b.GetLength(0), a.GetLength(1)];
                }
                else
                {
                    int[,] f = new int[b.GetLength(0), b.GetLength(1)];
                }
            }
            return f;

        }*/

        static void zad_4(int[,] a)
        {
            int k = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < k) k = a[i, j];
                }
            }
            Console.WriteLine("najmniejszy element: " + k);


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");
            Zad_1();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zadanie 2");
            Zad_2();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Zadanie 4");
            int[,] b = new int[2, 2]
            {
                {22,13 },
                {23,11 }
            };
            zad_4(b);

            Console.ReadKey();

        }
    }
}
