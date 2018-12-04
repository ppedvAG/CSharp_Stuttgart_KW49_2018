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

            Console.WriteLine($"Die Zahl ist {eineZahl}");
            Console.ReadLine();
        }

        static void SagHallo()
        {
            ZeigeText("Hallo");
        }

        static void ZeigeText(string text)
        {
            Console.WriteLine(text);
        }

        static int GetZahl()
        {
            return 5;
        }
    }
}
