using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamFileReader();
            var people = reader.ReadPeople("dane.txt");

            var Sortedpeople = people.OrderBy(x => x.nazwisko).ThenBy(x => x.imie);

            foreach (var People in Sortedpeople)
            {
                Console.WriteLine(People.nazwisko +" "+ People.imie);
            }
            Writer writer = new Writer();
            Phone phone = new Phone();
            writer.WriteTofile(Sortedpeople.First(), "result.txt");
            phone.PhoneToFile(Sortedpeople.First(),"phone.txt");


            Console.ReadKey();
        }
    }
}
