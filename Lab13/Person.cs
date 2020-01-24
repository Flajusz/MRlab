using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab13
{
    class Person
    {
        public Person(int id, string imie, string nazwisko, string telefon)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.telefon = telefon;
        }

        public int id { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
         public string telefon { get; set; }


    }
}
