using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.ServiceReference1;
using WindowsFormsApplication2.ServiceReference2;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.CookingUnitSoapClient client = new CookingUnitSoapClient("CookingUnitSoap");
            label1.Text = client.ChangeCookingUnit(2, Cookings.cupUS, Cookings.deciliter).ToString();
        }
    }
}
