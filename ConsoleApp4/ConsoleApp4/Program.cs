using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Console.WriteLine("Wpisuj kolejne wiersze (po spacji do njowej kolumny): ");
            Console.ReadLine();*/

            int[][] J = new int[3][];
            string s = "";

            for (int i = 0; i< J.Length; i++)
            {
                J[i][] = new int[3][];
                for(int j = 0; j < J[0].Length; j++)
                {

                }
            }
            for (int i = 0; i < 100; i++)
            {
                string s = Console.ReadLine();
                if (s == "")
                {
                    Console.WriteLine("pusty");
                    break;
                }
                return;
            }
        }
    }
}
            /* Stopwatch stopwatch = new Stopwatch();
             stopwatch.Start();

             int[][] Jagged1;
             Jagged1 = new int[4][];
             Jagged1[0] = new int[3];
             Jagged1[1] = new int[6];
             Jagged1[2] = new int[2];
             Jagged1[3] = new int[4];

             int[,] vs = new int[4, 6];

             int [] [] Jagged2;
             Jagged2 = new int[4][];
             for (int i = 0; i<Jagged2.Length; i++)
             {
                 Jagged2[i] = new int[6];

                 int[] X = Jagged2[3];
                 int[] Y = new int[Regular1.GetLength(1)];
                 for (int i= 0; i < Y.Length; i++)
                 {
                     Y[i] = Regular1[3, i];

                     int [][][] 33;
                     int[,,] R3;

                     J3 = new int[3][][];

                     for(int j =0; j<33[0].Length; Jagged2++)
                     {
                         33[i][j] = new int[7];
                     }

                     int a = 33[2][1][3];
                     int[][][,,,][][][] T;
                 }
             }

             stopwatch.Stop();
             Console.WriteLine(stopwatch.Elapsed);
             Console.ReadLine();



             using (StreamReader sr = new StreamReader(@"C:\Users\student\Desktop\f1.txt"))
             {
                 using (StreamReader sw = new StreamReader(@"C:\Users\student\Desktop\f2.txt"))
                 {
                     string s;
                     while ((s = sw.ReadLine()) != null)
                     {
                         string[] s23 = s.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                         for (int i = 0; i < s23.Length; i++)
                         {
                             sw.Write(Convert.ToDouble(s23[i]) * 10 + " ");
                         }
                         sw.WriteLine(s);
                     }
                 }
             }



             Console.WriteLine("N = ");
             int N = Convert.ToInt32(Console.ReadLine());
             int[,] tab1 = new int [N,N];
             int i1 = 0;
             string s = Console.ReadLine();
             string[] s22 = s.Split(' ');
             string[] s23 = s.Split(new string[](' ', '\t', ';')StringSplitOptions.RemoveEmptyEntries RemoveEmptyEntries);

             int i2 = 0;
             string ls = "";
             for(int j = 0; j< s.Length; j++)
             {
                 if(s[j] != ' ')
                     ls += s[j];
                 else
                 {
                     tab1[i1][i2] = Convert.ToInt32(ls);
                     i2++;
                     */
