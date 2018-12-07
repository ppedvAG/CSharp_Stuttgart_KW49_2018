using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using HalloKlassen;

namespace Motorradverwaltung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var liste = new List<Rennmotorrad>();
            var herstellerListe = new string[] { "Yamaha", "Suzuki", "BMW", "Kawasaki" };

            var ran = new Random();

            for (int i = 0; i < 100; i++)
            {
                var meinRad = new Rennmotorrad
                {
                    Ps = ran.Next(20, 3000),
                    Hersteller = herstellerListe[ran.Next(0, herstellerListe.Length)]
                };

                liste.Add(meinRad);
            }

            dataGridView1.DataSource = liste;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Es wurde keine Motorräder geladen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dlg = new SaveFileDialog()
            {
                Title = "Wo soll die Motorradatei gespeichert werden",
                Filter = "Motorraddatei|*.txt|Alle Dateien|*.*"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var writer = new StreamWriter(dlg.FileName);
                var t = ";";
                foreach (var i in (List<Motorrad>)dataGridView1.DataSource)
                {
                    writer.WriteLine($"{i.Hersteller}{t}{i.Ps}{t}{i.Farbe}{t}{i.Baujahr}{t}");
                }

                writer.Close();
                MessageBox.Show($"Erfogreich in {dlg.FileName} gespeichert");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog()
            {
                Title = "Welche Motorradatei soll geladen werden",
                Filter = "Motorraddatei|*.txt|Alle Dateien|*.*"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var liste = new List<Motorrad>();

                var reader = new StreamReader(dlg.FileName);
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var teile = line.Split(';');
                    var mr = new Rennmotorrad()
                    {
                        Hersteller = teile[0],
                        Ps = int.Parse(teile[1]),
                        Farbe = teile[2],
                        Baujahr = DateTime.Parse(teile[3])
                    };
                    liste.Add(mr);
                }
                reader.Close();
                dataGridView1.DataSource = liste;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Es wurde keine Motorräder geladen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dlg = new SaveFileDialog()
            {
                Title = "Wo soll die Motorradatei gespeichert werden",
                Filter = "Motorraddatei|*.xml"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var writer = new StreamWriter(dlg.FileName);
                var serial = new XmlSerializer(typeof(List<Rennmotorrad>));
                
                serial.Serialize(writer, dataGridView1.DataSource);
                writer.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog()
            {
                Title = "Welche Motorradatei soll geladen werden",
                Filter = "Motorraddatei|*.xml"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var reader = new StreamReader(dlg.FileName);
                var serial = new XmlSerializer(typeof(List<Rennmotorrad>));
                dataGridView1.DataSource = serial.Deserialize(reader);
                reader.Close();
            }
        }
    }
}
