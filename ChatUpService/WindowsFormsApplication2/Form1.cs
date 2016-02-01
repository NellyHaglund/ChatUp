using System;
using System.ServiceModel;
using System.Windows.Forms;
using WindowsFormsApplication2.ServiceReference1;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Lägg in inlägg när klienten startar
            UpdateListBox();

            //Uppdatera inlägg var 3 sekund
            var timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += (sender, args) => UpdateListBox();
            timer.Start();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ChatServiceClient("Boudoir");
                var post = new CustomPost
                {
                    ChatRoomId = 3,
                    Comment = textBox1.Text,
                    Submitter = "Lisa",
                    TimeSubmitted = DateTime.Now
                };
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

        public void UpdateListBox()
        {
            //Måste lista ut hur vi får ut rätt inlägg baserat på endpoint
            var client = new ChatServiceClient("Boudoir");

            var posts = client.GetPosts(3);
            if (listBox1.Items.Count > 0) listBox1.Items.Clear();
            foreach (var customPost in posts)
            {
                listBox1.Items.Add(customPost.Comment);
            }
        }
    }
}