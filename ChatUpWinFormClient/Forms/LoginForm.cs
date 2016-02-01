using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatUpWinFormClient.Forms;

namespace ChatUpWinFormClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUserName.Text))
            {
                MessageBox.Show("Enter your name.");
            }
            else if(textBoxUserName.Text.Length < 2 || textBoxUserName.Text.Length > 20)
            {
                MessageBox.Show("Your name must be at least 2 characters long and at the most 20 characters.");
            }
            else
            {
                if (radioButtonMan.Checked)
                {
                    //this.Hide();
                    ManForm manForm = new ManForm(textBoxUserName.Text);
                    manForm.ShowDialog();
                    textBoxUserName.Text = "";
                    radioButtonMan.Checked = false;
                }
                else if (radioButtonWoman.Checked)
                {
                    //this.Hide();
                    WomanForm womanForm = new WomanForm(textBoxUserName.Text);
                    womanForm.ShowDialog();
                    textBoxUserName.Text = "";
                    radioButtonWoman.Checked = false;

                }
            }
        }

        private void radioButtonWoman_CheckedChanged(object sender, EventArgs e)
        {
            buttonLogin.Enabled = true;
        }

        private void radioButtonMan_CheckedChanged(object sender, EventArgs e)
        {
            buttonLogin.Enabled = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
