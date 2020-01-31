using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kolokwium_2
{
    class Pomiar
    {
        public double id;
        public double Temperetura;
        public double Wilgotnosc;
        public double PrWiatru;
        public double Cisnienie;

        public Pomiar(double id, double temperetura, double wilgotnosc, double prWiatru, double cisnienie)
        {
            this.id = id;
            Temperetura = temperetura;
            Wilgotnosc = wilgotnosc;
            PrWiatru = prWiatru;
            Cisnienie = cisnienie;
        }
    }

     class Zadanie_1
    {

       static Random rnd = new Random();
         List<Pomiar> pomiary = Enumerable.Range(1, 150).Select(x => new Pomiar
        (
            x,
            rnd.Next(-20, 30),
            rnd.Next(10, 90),
            rnd.Next(10, 50),
            rnd.Next(1, 5)
            )
        ).ToList();

        

        


       

            



    }
}
