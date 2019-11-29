using System;

namespace Lab_8
{
    class Program
    {
        static int MIN(int[][] tablica)
        {
            int min = int.MaxValue;
            foreach (var item in tablica)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[,] jeden = new int[3, 8];
            int[,] dwa = new int[5, 5];
            int rozniar1 = Math.Max(jeden.GetLength(0), dwa.GetLength(0));
            int rozniar2 = Math.Max(jeden.GetLength(1), dwa.GetLength(1));

            int[,] wynik = new int[rozniar1, rozniar2];

            for (int i = 0; i < jeden.GetLength(0); i++)
            {
                for (int j = 0; j < jeden.GetLength(1); j++)
                {
                    jeden[i, j] = 1; 

                }
            }
            for (int i = 0; i < dwa.GetLength(0); i++)
            {
                for (int j = 0; j < dwa.GetLength(1); j++)
                {
                    dwa[i, j] = 1;

                }
            }


            for (int i = 0; i < wynik.GetLength(0); i++)
            {
                for (int j = 0; i < wynik.GetLength(1); i++)
                {
                    if (i < jeden.GetLength(0) && j < jeden.GetLength(1)) wynik[i, j] += jeden[i, j];
                    if (i < dwa.GetLength(0) && j < dwa.GetLength(1)) wynik[i, j] += dwa[i, j];
                

                }
            }
            for (int i = 0; i < wynik.GetLength(0); i++)
            {
                for (int j = 0; j < wynik.GetLength(1); j++)
                {
                    Console.Write(wynik[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
