using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab13
{
    class StreamFileReader:IReader
    {
        public List<Person> ReadPeople(string FileName)
        {

            var reader = new StreamReader(FileName);
            string data = reader.ReadToEnd();

            string[] lines = data.Split(new[] { '\n', '\r' });

            string[] allData = File.ReadAllLines(FileName);
            var people = allData.Select(x =>
              {
                  string[] lineData = x.Split(',');
                  return new Person
                  (
                      Convert.ToInt32(lineData[0]),
                      lineData[1],
                      lineData[2],
                      lineData[3]

                  );

              }
            );
            return people.ToList();
        }
    }
}
