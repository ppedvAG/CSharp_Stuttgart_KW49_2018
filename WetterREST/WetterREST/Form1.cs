using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WetterREST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wb = new WebClient();
            string json = wb.DownloadString("https://query.yahooapis.com/v1/public/yql?u=c&q=select%20*%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22stuttgart%2Cde%22)&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys");
            textBox1.Text = json;

            WetterResult result = JsonConvert.DeserializeObject<WetterResult>(json);
            //MessageBox.Show(result.query.results.channel.wind.speed);
            dataGridView1.DataSource = result.query.results.channel.item.forecast;
        }
    }
}
