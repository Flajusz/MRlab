using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab13
{
    class IOReader:IReader
    {
        public List<Person> ReadPeople(string FileName)
        {

            var reader = new StreamReader(FileName);
            string data = reader.ReadToEnd();
            string[] lines = data.Split(new[] { '\n', '\r' });
            string[] allData = File.ReadAllLines(FileName);
            var people = allData.Select(x =>
            CSVPersonToString.Convert(x)
            );
            return people.ToList();
        }
    }
}
