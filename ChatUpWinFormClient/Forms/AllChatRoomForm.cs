using System;
using System.ServiceModel;
using System.Windows.Forms;
using ChatUpWinFormClient.ServiceReferenceChatUp;

namespace ChatUpWinFormClient.Forms
{
    public partial class AllChatRoomForm : Form
    {
        private readonly int _chatRoomId;
        private readonly ChatServiceClient _client;
        private readonly Timer _timer;
        private readonly string _userName;

        public AllChatRoomForm(string userName)
        {
            InitializeComponent();
            _userName = userName;
            labelLoggedInAll.Text = $"Logged in as: {_userName}";
            _chatRoomId = 3;
            _timer = new Timer {Interval = 3000};

            try
            {
                _client = new ChatServiceClient("All");
                UpdateTexts();
                _timer.Tick += (sender, args) => UpdateTexts();
                _timer.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Not connected to the service, application will exit");
                Application.Exit();
            }
            if (richTextBoxMessageAll.TextLength == 0)
            {
                buttonSendMessageAll.Enabled = false;
            }
        }

        private void buttonSendMessageAll_Click(object sender, EventArgs e)
        {
            _timer.Start();
            try
            {
                var post = new CustomPost
                {
                    Submitter = _userName,
                    TimeSubmitted = DateTime.Now,
                    Comment = richTextBoxMessageAll.Text,
                    ChatRoomId = _chatRoomId,
                    IsActive = true
                };
                _client.SubmitPost(post);
                richTextBoxMessageAll.Clear();
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
            listViewMessageAll.Clear();
            var result = _client.GetPosts(_chatRoomId);
            foreach (var customPost in result)
            {
                var item = new ListViewItem
                {
                    Name = customPost.Id.ToString(),
                    Text = $"{customPost.Submitter} {customPost.TimeSubmitted} {customPost.Comment}"
                };
                listViewMessageAll.Items.Add(item);
            }
            if (listViewMessageAll.Items.Count != 0)
                listViewMessageAll.Items[listViewMessageAll.Items.Count - 1].EnsureVisible();
        }

        private void buttonRemovePost_Click(object sender, EventArgs e)
        {
            var result = listViewMessageAll.SelectedItems;
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

        private void richTextBoxMessageAll_TextChanged(object sender, EventArgs e)
        {
            _timer.Start();

            var counter = richTextBoxMessageAll.TextLength;
            lblTextCounter.Text = (55 - counter).ToString();
            buttonSendMessageAll.Enabled = counter != 0;
        }

        private void listViewMessageAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            _timer.Stop();
        }
    }
}