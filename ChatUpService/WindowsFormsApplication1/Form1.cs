using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ServiceReference1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ChatServiceClient("ManCave");
                client.RemovePost(int.Parse(textBox1.Text));
            }
            catch (FaultException exception)
            {

                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ChatServiceClient("All");
                var posts = client.GetPosts(int.Parse(textBox2.Text));
                foreach (var customPost in posts)
                {
                    label1.Text += $"{customPost.Submitter}\r\n";
                }
            }
            catch (FaultException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ChatServiceClient("Boudoir");
                var post = new CustomPost() {ChatRoomId = int.Parse(textBox3.Text), Comment = textBox5.Text, Submitter = textBox4.Text, TimeSubmitted = DateTime.Now};
               client.SubmitPost(post);
            }
            catch (FaultException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
