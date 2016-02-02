using System;
using System.ServiceModel;
using System.Windows.Forms;
using ChatUpWinFormClient.ServiceReferenceChatUp;

namespace ChatUpWinFormClient.Forms
{
    public partial class MenChatRoomForm : Form
    {
        private readonly int _chatRoomId;
        private readonly ChatServiceClient _client;
        private readonly Timer _timer;
        private readonly string _userName;

        public MenChatRoomForm(string userName)
        {
            InitializeComponent();
            _userName = userName;
            labelLoggedInMen.Text = $"Logged in as: {_userName}";
            _chatRoomId = 1;
            _timer = new Timer {Interval = 3000};

            try
            {
                _client = new ChatServiceClient("ManCave");
                UpdateTexts();
                _timer.Tick += (sender, args) => UpdateTexts();
                _timer.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Not connected to the service, application will exit");
                Application.Exit();
            }
            if (richTextBoxMessageMen.Text.Length == 0)
            {
                buttonSendMessageMen.Enabled = false;
            }
        }

        private void buttonSendMessageMen_Click(object sender, EventArgs e)
        {
            _timer.Start();
            try
            {
                var post = new CustomPost
                {
                    Submitter = _userName,
                    TimeSubmitted = DateTime.Now,
                    Comment = richTextBoxMessageMen.Text,
                    ChatRoomId = _chatRoomId,
                    IsActive = true
                };
                _client.SubmitPost(post);
                richTextBoxMessageMen.Clear();
                UpdateTexts();
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

        private void UpdateTexts()
        {
            listViewMessageMen.Clear();
            var result = _client.GetPosts(_chatRoomId);
            foreach (var customPost in result)
            {
                var item = new ListViewItem
                {
                    Name = customPost.Id.ToString(),
                    Text = $"{customPost.Submitter} {customPost.TimeSubmitted} {customPost.Comment}"
                };
                listViewMessageMen.Items.Add(item);
            }
            if (listViewMessageMen.Items.Count != 0)
                listViewMessageMen.Items[listViewMessageMen.Items.Count - 1].EnsureVisible();
        }

        private void buttonRemovePost_Click(object sender, EventArgs e)
        {
            var result = listViewMessageMen.SelectedItems;
            if (result.Count > 0)
            {
                try
                {
                    _client.RemovePost(int.Parse(result[0].Name));
                    UpdateTexts();
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
            else
            {
                MessageBox.Show("Choose a post to remove.");
            }
            _timer.Start();
        }

        private void listViewMessageMen_SelectedIndexChanged(object sender, EventArgs e)
        {
            _timer.Stop();
        }


        private void richTextBoxMessageMen_TextChanged(object sender, EventArgs e)
        {
            _timer.Start();

            var counter = richTextBoxMessageMen.TextLength;
            lblTextCounter.Text = (55 - counter).ToString();
            buttonSendMessageMen.Enabled = counter != 0;

        }
    }
}