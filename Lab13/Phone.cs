using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab13
{
    class Phone
    {
        public void PhoneToFile(Person person, string FileName) {

            using (StreamWriter phone = new StreamWriter(FileName, true))
            {
                phone.Write($"{person.telefon}");
            }
                
        }
    }
}
