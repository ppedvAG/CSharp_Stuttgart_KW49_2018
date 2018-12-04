using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HalloSchleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Schleifen");



            //int[] zahlen = new[] { 3, 77, 11, -9, 85 };

            //string[] texte = new string[3];
            //texte[0] = "Erste Zeile";
            //texte[1] = "Zweite Zeile";
            //texte[2] = "Dritte Zeile";


            //Console.WriteLine("Args:");
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine(args[i]);
            //}

            Console.WriteLine("----------------------------");
            var liste = new List<string>();
            liste.Add("Hallo");
            liste.Add("Welt!");
            liste.Add("Ist");
            liste.Add("noch");
            liste.Insert(0, "Bier");
            liste.Add("da?");
            liste.Remove("Ist");

            foreach (string item in liste.Where(x => x.StartsWith("B")).OrderBy(x => x.Length))
            {
                Console.WriteLine(item);
            }


            //var sw = new StreamWriter("zahlen.txt");
            //for (int i = 0; i < 100; i++)
            //{
            //    sw.WriteLine($"{i * i}");
            //}
            //sw.Close();

            var sr = new StreamReader("zahlen.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (line.StartsWith("1"))
                    Console.WriteLine($">{line}");
            }
            sr.Close();


            do
            {
                Console.WriteLine("Einmal geht immer");
            } while (false);


            Console.ReadLine();
        }
    }
}
