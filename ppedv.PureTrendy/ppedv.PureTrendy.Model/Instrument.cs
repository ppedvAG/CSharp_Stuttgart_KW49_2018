using System.Collections.Generic;

namespace ppedv.PureTrendy.Model
{
    public class Instrument
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public List<Orchester> Orchester { get; set; } = new List<Orchester>();
    }
}
