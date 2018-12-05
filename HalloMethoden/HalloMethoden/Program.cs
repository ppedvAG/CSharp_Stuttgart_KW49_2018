using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Methoden und Funktionen");

            SagHallo();
            int eineZahl = GetZahl();
            ZeigeText(888);
            Console.WriteLine($"Die Zahl ist {eineZahl}");
            Console.ReadLine();
        }

        static void SagHallo()
        {
            ZeigeText($"Hallo {DateTime.Now:T}");
            ZeigeText("Temp:", 7);
        }

        static void ZeigeText(string text)
        {
            ZeigeText(text, 12);
        }

        static void ZeigeText(string text, int zahl)
        {
            Console.WriteLine($"{text}:{zahl}");
        }

        static void ZeigeText(int zahl)
        {
            ZeigeText("--",zahl);
        }

        static int GetZahl()
        {
            return 5;
        }

        static int Verdoppeln(int zahl)
        {
            if (zahl > 1000)
                return zahl;

            return zahl * 2;
        }
    }
}
