using System;

namespace Lab12
{
    class Program
    {
        static double oblicz_cene_biletu(object pasazer)
        {
            /*
            if (pasazer is Dziecko dziecko)
            {
                Console.WriteLine($"To dziecko, ma zniżkę {dziecko.znizka}");
            }
            else if (pasazer is Emeryt emeryt)
            {
                Console.WriteLine("To emeryt");
                if (emeryt.Zwolnienie == true)
                {
                    Console.WriteLine("Ma darmowy przejazd");
                }
            }
            else
            {
                Console.WriteLine("Osoba płaci normalnie");
            }
            */

            
            switch (pasazer)
            {
                case Dziecko d:
                    Console.WriteLine($"To dziecko, ma zniżkę {d.znizka}");
                    break;
                case Emeryt eme when eme.Zwolnienie:
                    Console.WriteLine("To emeryt,ma darmowy przejazd");
                    break;
                case Emeryt _:
                    Console.WriteLine("To emeryt");
                    break;
                case null:
                    Console.WriteLine("nie podano pasażera");
                    break;
                case Rencista ren when ren.okres_waznosci >= System.DateTime.Now && ren.Zwolnienie==true:
                    Console.WriteLine("To rencista z ważnym zwolnieniem");
                    break;
                case Rencista _:
                    Console.WriteLine("To rencista bez ważnego zwolnienia");
                    break;
                default:
                    Console.WriteLine("Osoba płaci normalnie");
                    break;


            }
            
            return 0;

        }
        

        static void Main(string[] args)
        {
            var pasazer = new Pasazer();
            var dziecko = new Dziecko() { znizka = 0.5 };
            var emeryt = new Emeryt() { Zwolnienie = true };
            var rencista_1 = new Rencista() { Zwolnienie = true, okres_waznosci=new DateTime(2021, 02, 01) };
            var rencista_2 = new Rencista() { Zwolnienie = true, okres_waznosci = new DateTime(2019, 06, 12) };
            var rencista_3 = new Rencista() { Zwolnienie = false, okres_waznosci = new DateTime(2021, 02, 01) };


            /*
            Console.WriteLine("Zwykły pasażer");
            oblicz_cene_biletu(pasazer);
            Console.WriteLine("Zwykły pasażer");
            oblicz_cene_biletu(dziecko);
            Console.WriteLine("Zwykły pasażer");
            oblicz_cene_biletu(emeryt);
            Console.WriteLine("Zwykły pasażer");
            oblicz_cene_biletu("pasazer");
            Console.WriteLine("Zwykły pasażer");
            oblicz_cene_biletu(null);
            */
            oblicz_cene_biletu(rencista_1);
            oblicz_cene_biletu(rencista_2);
            oblicz_cene_biletu(rencista_3);
            Console.ReadKey();
        }
    }
}
