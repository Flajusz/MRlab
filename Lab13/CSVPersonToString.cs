using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class CSVPersonToString
    {
        public static Person Convert(string CsvString)
        {
            string[] lineData = CsvString.Split(',');
            return new Person
            (
                System.Convert.ToInt32(lineData[0]),
                lineData[1],
                lineData[2],
                lineData[3]

            );

        }
            

    }
}
