using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.ServiceReference1;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeWorkers();
        }

        private void InitializeWorkers()
        {
            var bottomLabelsThread = new Thread(new ThreadStart(updateChat)) { IsBackground = true };
            bottomLabelsThread.Start();
        }


        public void updateChat()
        {
            var client = new ChatServiceClient("Boudoir");
                while (true)
                {
                    var posts = client.GetPosts(3);
                    if (listBox1.Items.Count > 0) listBox1.Items.Clear();

                foreach (var customPost in posts)
                    {
                        listBox1.Items.Add(customPost.Comment);
                    }
                    Thread.Sleep(1000);
                }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ChatServiceClient("Boudoir");
                var post = new CustomPost() { ChatRoomId = 3, Comment = textBox1.Text, Submitter = "Lisa", TimeSubmitted = DateTime.Now };
                client.SubmitPost(post);
                listBox1.Items.Add(post.Comment);
                textBox1.Clear();
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
