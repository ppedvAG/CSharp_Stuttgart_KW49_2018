using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloKlassen
{
    public class Cross : Motorrad
    {
        public Cross()
        {
            FahrgestellNummer = "CCCCCCC";
        }

        public override void Fahren()
        {
            base.Fahren();
            Console.WriteLine("CROSS fährt");
        }

        public override string SagMirWasDuBist()
        {
            return "Ich bin eine Crossmaschine";
        }

        public bool Schutzblech { get; set; }
    }
}
