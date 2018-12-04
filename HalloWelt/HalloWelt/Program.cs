using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWelt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Welt!");

            sbyte achtBit = -87;

            uint zahl;
            zahl = 3;

            ulong grosseZahl = 18376433764376437634;

            DateTime dt = new DateTime(2018, 12, 4, 12, 30, 4);

            float kommaZahl = 64.857F;
            double besserKommaZahl = 74.2873;
            decimal money = 85633.234324M;

            Console.WriteLine(money * (decimal)besserKommaZahl * -achtBit);

            besserKommaZahl = zahl;//implizit
            zahl = (uint)besserKommaZahl;

            Console.WriteLine("Zahl eingeben:");
            string text = Console.ReadLine();

            //parsing old-school
            //  int textAlsZahl = int.Parse(text);
            //  Console.WriteLine("Das doppelte:" + textAlsZahl * 2);

            if (int.TryParse(text, out int textAlsZahlInCool))
                Console.WriteLine("Das doppelte in cool " + textAlsZahlInCool * 2);
            else
                Console.WriteLine("Eingabe ungültig");


            char zeichen = 'L';

            bool einBool = true | !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!false;

            if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday && DateTime.Now.Hour > 12)
            {
                Console.WriteLine("Schönen Dienstag Nachmittag!");
            }
            else
            {
                Console.WriteLine("Es ist nicht Dienstag Nachmittag!");
            }



            Console.ReadLine();
        }
    }
}
