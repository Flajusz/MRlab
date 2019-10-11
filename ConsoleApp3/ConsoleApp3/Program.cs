using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3, 5, 7, 9 };
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[] B = A;
            for  (int i = 0; i< A.Length; i++)
            {
                Console.WriteLine(B[i]);

            }
            Console.WriteLine();
            B[2] = 100;
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i] + "    " + B[i]);

            }

            int[] C = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i];
            }
            A[2] = 100
            Console.ReadLine();

            C[2] = 500
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i] + "  " + C[i]);
            }
            Console.WriteLine("-----------------");
            int[,] D = new int[4, 3];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                    D[i, j] = 10 * i + j;
            }

            for(int i = 0; 1 < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.WriteLine(D[i, j]+" ");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
