using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {

        /* static void opisz(Auto samochod)
         {
             Console.WriteLine(samochod.model+"; "+ samochod.przebieg+" km;"+ samochod.ilosc_drzwi+";" + samochod.waga+";"+ samochod.VIN+";");
         }
         */
        static void opiszSerwer(Serwer strona)
        {
            Console.WriteLine(strona.SzybProcesora + "GHz, Łącze: " + strona.Lacze + ", " + strona.Ram + "GB, " + strona.Technologia);
        }

        static void Main(string[] args)
        {
            /*  
        Auto mojeAuto = new Auto
        (
            100000,"A4",5,1000
        );

        Auto s1 = new Auto
        (
            200000, "Multipla", 5, 1500
        );

        Auto s2 = new Auto
        (
            150000, "Seicento", 4, 800
        );

        Auto nowy = new Auto
        (
           4, 2000
        );

        mojeAuto.zwiekszprzebieg(10000);
        opisz(mojeAuto);
        opisz(s1);
        opisz(s2);
        opisz(nowy);


        */
            Serwer Serwer_nr1 = new Serwer(
               4, 5, 16, ".NET");
            opiszSerwer(Serwer_nr1);

            Console.ReadKey();
        }
    }
}
