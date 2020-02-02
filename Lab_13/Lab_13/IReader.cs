using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    interface IReader
    {
        List<Person> ReadPeople(string FileName);
    }
}
