using System.Collections.Generic;

namespace ppedv.PureTrendy.Model
{
    public class Orchester
    {
        public string Name { get; set; }
        public List<Instrument> Instrumente { get; set; } = new List<Instrument>();
    }
}
