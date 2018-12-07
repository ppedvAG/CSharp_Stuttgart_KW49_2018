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
            Console.WriteLine("*** Hallo Klassen ***");

            Motorrad meinMotorrad = null; //deklaration
            meinMotorrad = new Rennmotorrad(); //instanzierung
            //meinMotorrad.Hersteller = "BMW";
            meinMotorrad.Ps = 36;
            ZeigeMotorrad(meinMotorrad);
            ZeigeMotorrad(meinMotorrad);


            //Motorrad zweitMotorrad = new Motorrad();
            var zweitMotorrad = new Cross()
            {
                Hersteller = "Suzuki",
                Ps = 136,
                Farbe = "Rot",
                Baujahr = new DateTime(1989, 1, 21)
            };
            ZeigeMotorrad(zweitMotorrad);


            var rennmo = new Rennmotorrad
            {
                Heckspoiler = true,
                Turbo = 2000,
                Farbe = "Blau",
                Ps = 8000,
                Hersteller = "Duplo"
            };

            ZeigeMotorrad(rennmo);

            var cross = new Cross()
            {
                Schutzblech = true,
                Farbe = "Gelb",
                Ps = 12,
                Hersteller = "Jeep"
            };

            ZeigeMotorrad(cross);


            Console.WriteLine("Ende");
            Console.ReadLine();
        }

        static void ZeigeMotorrad(Motorrad mr)
        {
            Console.WriteLine(mr.SagMirWasDuBist());

            if (mr is IElektro elektro)
            {
                Console.WriteLine(elektro.GetBatterieTyp());
            }

            //#1 old school casing mit is
            if (mr is Cross)
            {
                Cross cross = (Cross)mr; //casting

                if (cross.Schutzblech)
                    Console.WriteLine("Ist cross mit Schutzblech");
                else
                    Console.WriteLine("Ist cross ohne Schutzblech");
            }

            //#2 ab .net 2.0: boxing
            Cross mrAsCross = mr as Cross;
            if (mrAsCross != null)
            {
                if (mrAsCross.Schutzblech)
                    Console.WriteLine("Ist cross mit Schutzblech");
                else
                    Console.WriteLine("Ist cross ohne Schutzblech");
            }

            //#3 ab C#6 (VS2015): pattern matching
            if (mr is Cross mrIsCross)
            {
                if (mrIsCross.Schutzblech)
                    Console.WriteLine("Ist cross mit Schutzblech");
                else
                    Console.WriteLine("Ist cross ohne Schutzblech");
            }

            Console.WriteLine($"Das Motorrad hat {mr.Ps} PS");
            if (mr.Ps < 1000)
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
