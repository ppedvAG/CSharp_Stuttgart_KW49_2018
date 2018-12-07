using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloKlassen
{
    public interface IElektro
    {
        int Ah { get; set; }

        string GetBatterieTyp();
    }
}
