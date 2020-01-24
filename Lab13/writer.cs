using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab13
{
    class Writer
    {
        public void WriteTofile(Person person,string FileName)
        {
            using (StreamWriter writer = new StreamWriter(FileName, true))
            {
                writer.Write($"[{person.id}] {person.imie} { person.nazwisko}");
            }
            

        } 
    }
}
