using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _24._10_1b
{
    class Program
    {         
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\student\Desktop\f1.txt"))
            {
                using (StreamReader sw = new StreamReader(@"C:\Users\student\Desktop\f2.txt"))
                {
                    string s;
                    while ((s = sw.ReadLine()) != null)
                    {
                        String line = sr.ReadToEnd();
                        Console.WriteLine(line);
                    }
                }
            }
            Console.ReadLine();
            
            
            /*
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
                }
            }*/
        }
        }

}
