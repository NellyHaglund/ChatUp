using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new ServiceReference1.countrySoapClient("countrySoap");
            var country = client.GetCountries();
            label1.Text = country;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = new ServiceReference2.WeatherSoapClient("WeatherSoap");
            label1.Text = client.GetCityForecastByZIP("26142").City;
        }
    }
}
