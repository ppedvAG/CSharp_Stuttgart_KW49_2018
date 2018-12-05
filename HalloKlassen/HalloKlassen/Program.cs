using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloKlassen
{
    class Program
    {
        static void Main(string[] args)
        {

            int zahl = 7;
            Console.WriteLine(zahl);
            Verdoppeln(zahl);
            Console.WriteLine(zahl);

            decimal gehalt = 34567;


            Console.WriteLine("*** Hallo Klassen ***");

            Motorrad meinMotorrad = null; //deklaration

            ZeigeMotorrad(meinMotorrad);

            meinMotorrad = new Motorrad("BMW"); //instanzierung
            //meinMotorrad.Hersteller = "BMW";
            meinMotorrad.Ps = 36;
            ZeigeMotorrad(meinMotorrad);
            ZeigeMotorrad(meinMotorrad);


            //Motorrad zweitMotorrad = new Motorrad();
            var zweitMotorrad = new Motorrad("Susi")
            {
                Hersteller = "Suzuki",
                Ps = 136,
                Farbe = "Rot",
                Baujahr = new DateTime(1989, 1, 21)
            };
            ZeigeMotorrad(zweitMotorrad);

            Console.WriteLine("Ende");
            Console.ReadLine();
        }

        static void ZeigeMotorrad(Motorrad mr)
        {



            Console.WriteLine($"Das Motorrad hat {mr.Ps} PS");
            mr.Fahren();
        }

        static void Verdoppeln(int z)
        {
            z = z * 2;
        }
    }

    struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
