using System;
using System.Collections.Generic;
using System.Text;

namespace ppedv.PureTrendy.Model
{
    public class FridayAfternoonException : Exception
    {
        public DateTime Datum { get; set; }

    }
}
