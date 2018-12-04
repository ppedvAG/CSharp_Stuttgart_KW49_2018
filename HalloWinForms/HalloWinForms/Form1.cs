using System;
using System.Globalization;
using System.Windows.Forms;

namespace HalloWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Der Text ist: " + textBox1.Text);
            MessageBox.Show(string.Format("Der Text ist {0} mit der Zahl {1:00.00}", textBox1.Text, numericUpDown1.Value));
            MessageBox.Show($"Der Text ist {textBox1.Text} mit der Zahl {numericUpDown1.Value:00.00}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numericUpDown1.Value.ToString("c", new CultureInfo("en-GB")));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionStart.ToString("yy yyyy MM MMM MMMM dd ddd dddd"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //    monthCalendar1.Left = monthCalendar1.Left - 1;
            //    monthCalendar1.Left -= 1;
            monthCalendar1.Left--;
        }
    }
}
