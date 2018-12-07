using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloKlassen
{

    public class Rennmotorrad : Motorrad, IElektro
    {
        public int Turbo { get; set; }
        public bool Heckspoiler { get; set; }

        public int Ah { get; set; }

        public string GetBatterieTyp()
        {
            return "High Performace LiPo Ultra Light PRO 4000";
        }

        public override string SagMirWasDuBist()
        {
            return "Ich bin ein Rennmotorrad";
        }
    }
}
