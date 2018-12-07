using ppedv.PureTrendy.Data.XML;
using ppedv.PureTrendy.Model;
using System;
using System.Collections.Generic;

namespace ppedv.PureTrendy.UI.CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var schlagis = new List<Schlaginstrument>();
            //schlagis.Add(new Schlaginstrument()
            //{
            //    Name = "Trommel",
            //    Flaeche = 20,
            //    Material = "Knochen",
            //    OverflaechenMaterial = "Fell"
            //});

            //schlagis.Add(new Schlaginstrument()
            //{
            //    Name = "Xylophon",
            //    Flaeche = 12,
            //    Material = "Holz",
            //    OverflaechenMaterial = "Holz"
            //});

            //ShowSchlagi(schlagis);

            var manager = new XmlManager();
            //manager.Save<Blasinstrument>(new[] { new Blasinstrument() { Name = "B1" }, new Blasinstrument() { Name = "Flöte" } });
            //manager.SaveSchlaginstrumente(schlagis);

            try
            {
                ShowSchlagi(new XmlManager().Load<Schlaginstrument>());
            }
            catch (FridayAfternoonException faex)
            {
                Console.WriteLine("Feierabend!!!!");
            }
            catch (System.IO.FileNotFoundException fex)
            {
                Console.WriteLine($"Datei wurde nicht gefunden. Gesuch wurde: {fex.FileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }



            Console.WriteLine("Ende");
            Console.ReadLine();
        }

        private static void ShowSchlagi(IEnumerable<Schlaginstrument> schlagis)
        {
            foreach (var s in schlagis)
            {
                Console.WriteLine($"{s.Name} {s.Flaeche:0.00} {s.Material} {s.OverflaechenMaterial}");
            }
        }
    }
}
