using DVDScreenSaver.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDScreenSaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //kommentar
#if DEBUG
            //MessageBox.Show("DEBUG");
#endif

            this.StartPosition = FormStartPosition.Manual;
            this.Left = Settings.Default.PosX;
            this.Top = Settings.Default.PosY;


            button1.TripleClick += Button1_TripleClick;
            button1.TripleClick += Button1_TripleClick;
            button1.TripleClick += Button1_TripleClick;
            button1.TripleClick -= Button1_TripleClick;
            button1.TripleClick -= Button1_TripleClick;
            

            //this.Click += (s, e) => MessageBox.Show("Daneben");
        }


        private void Button1_TripleClick(object sender, int clickCount)
        {
            MessageBox.Show("LALA");
        }

        int speedX = 2;
        int speedY = 2;


        private void timer1_Tick(object sender, EventArgs e)
        {

            if (button1.Right >= ClientRectangle.Right || button1.Left <= 0)
            {
                speedX *= -1;
                ChangeColor();
            }

            if (button1.Bottom >= ClientRectangle.Bottom || button1.Top <= 0)
            {
                speedY *= -1;
                ChangeColor();
            }

            button1.Left += speedX;
            button1.Top += speedY;

            Text = $"{button1.Left}x{button1.Top}";
        }
        Random ran = new Random();
        private void ChangeColor()
        {
            Task.Run(() => Console.Beep());
            button1.BackColor = GetRandomColor();
            BackColor = GetRandomColor();
        }

        private Color GetRandomColor()
        {
            return Color.FromArgb(ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
        }

        private void button1_TripleClick(object sender, int clickCount)
        {
            MessageBox.Show($"TripleClick {clickCount}");
        }
    }
}
