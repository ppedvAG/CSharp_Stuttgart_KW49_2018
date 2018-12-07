using ppedv.PureTrendy.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ppedv.PureTrendy.Data.XML
{
    public class XmlManager
    {
        const string SchlaginstrumenteFileName = "Schlaginstrumente.xml";

        public IEnumerable<Schlaginstrument> LoadSchlaginstrumente()
        {
            using (var reader = new StreamReader(SchlaginstrumenteFileName))
            {
                var serial = new XmlSerializer(typeof(List<Schlaginstrument>));
                return (IEnumerable<Schlaginstrument>)serial.Deserialize(reader);
            }
        }

        public void SaveSchlaginstrumente(IEnumerable<Schlaginstrument> schlaginstrumente)
        {
            using (var writer = new StreamWriter(SchlaginstrumenteFileName))
            {
                var serial = new XmlSerializer(typeof(List<Schlaginstrument>));
                serial.Serialize(writer, schlaginstrumente.ToList());
            } //writer.Dispose()  ---> //writer.Close();
        }


        public void Save<T>(IEnumerable<T> dinger)
        {
            using (var writer = new StreamWriter($"{typeof(T).Name}.xml"))
            {
                var serial = new XmlSerializer(typeof(List<T>));
                serial.Serialize(writer, dinger.ToList());
            }
        }

        public IEnumerable<T> Load<T>()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday &&
                DateTime.Now.Hour >= 15)
            {
                throw new FridayAfternoonException() { Datum = DateTime.Now };
            }

            using (var reader = new StreamReader($"{typeof(T).Name}.xml"))
            {
                var serial = new XmlSerializer(typeof(List<T>));
                return (IEnumerable<T>)serial.Deserialize(reader);
            }
        }


    }
}
