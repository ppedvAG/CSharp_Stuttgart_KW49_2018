using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloBinding
{
    public partial class Form1 : Form
    {
        BindingSource bs = new BindingSource();


        #region ctor

        public Form1()
        {
            InitializeComponent();

            textBox2.DataBindings.Add(nameof(textBox2.Text), textBox1, nameof(textBox1.Text), true, DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add(nameof(textBox1.BackColor), textBox1, nameof(textBox1.Text), true, DataSourceUpdateMode.OnPropertyChanged);


            listBox1.Format += ListBox1_Format;
            listBox1.DoubleClick += ListBox1_Click;
            panel1.DoubleClick += Panel1_DoubleClick;

            var daten = new List<Haus>();
            daten.Add(new Haus() { AnzahlStockwerke = 6, Farbe = "Blue" });
            daten.Add(new Haus() { AnzahlStockwerke = 2, Farbe = "Green" });
            daten.Add(new Haus() { AnzahlStockwerke = 12, Farbe = "Pink" });
            bs.DataSource = daten;
            listBox1.DataSource = bs;
            dataGridView1.DataSource = bs;


            textBox3.DataBindings.Add(nameof(TextBox.Text), bs, nameof(Haus.Farbe), true, DataSourceUpdateMode.OnPropertyChanged);
            panel1.DataBindings.Add(nameof(Panel.BackColor), bs, nameof(Haus.Farbe), true, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDown1.DataBindings.Add(nameof(numericUpDown1.Value), bs, nameof(Haus.AnzahlStockwerke), true, DataSourceUpdateMode.OnPropertyChanged);


        }

        #endregion

        private void Panel1_DoubleClick(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = dlg.Color;
            }
        }


        private void ListBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null && listBox1.SelectedItem is Haus h)
            {
                MessageBox.Show($"{h.Farbe} House");
            }
        }

        private void ListBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Haus h)
            {
                e.Value = $"Haus mit {h.AnzahlStockwerke} in der Farbe {h.Farbe}";
            }
        }
    }
}
