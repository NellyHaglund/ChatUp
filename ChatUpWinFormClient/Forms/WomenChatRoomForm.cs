using System;
using System.ServiceModel;
using System.Windows.Forms;
using ChatUpWinFormClient.ServiceReferenceChatUp;

namespace ChatUpWinFormClient.Forms
{
    public partial class WomenChatRoomForm : Form
    {
        private readonly string _userName;
        private readonly int _chatRoomId;
        private readonly ChatServiceClient _client;
        private readonly Timer _timer;

        public WomenChatRoomForm(string userName)
        {
            InitializeComponent();
            _userName = userName;
            labelLoggedInWomen.Text = $"Logged in as: {_userName}";
            _chatRoomId = 2;
            _client = new ChatServiceClient("All");

            UpdateTexts();
            _timer = new Timer {Interval = 3000};
            _timer.Tick += (sender, args) => UpdateTexts();
            _timer.Start();
        }

        private void UpdateTexts()
        {
            listViewMessageBoudoir.Clear();
            var posts = _client.GetPosts(_chatRoomId);
            foreach (var post in posts)
            {
                var item = new ListViewItem
                {
                    Name = post.Id.ToString(),
                    Text = $"{post.Submitter} {post.TimeSubmitted} {post.Comment}"
                };
                listViewMessageBoudoir.Items.Add(item);
            }
            listViewMessageBoudoir.Items[listViewMessageBoudoir.Items.Count - 1].EnsureVisible();
        }

        private void buttonSendMessageBoudoir_Click(object sender, EventArgs e)
        {
            try
            {
                var post = new CustomPost
                {
                    Submitter = _userName,
                    TimeSubmitted = DateTime.Now,
                    Comment = richTextBoxMessageBoudoir.Text,
                    ChatRoomId = _chatRoomId,
                    IsActive = true
                };
                _client.SubmitPost(post);
                richTextBoxMessageBoudoir.Clear();
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

        private void buttonRemovePost_Click(object sender, EventArgs e)
        {
            var result = listViewMessageBoudoir.SelectedItems;
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
                MessageBox.Show($"Choose a post to remove");
            }
            _timer.Start();
        }
        private void listViewMessageBoudoir_SelectedIndexChanged(object sender, EventArgs e)
        {
            _timer.Stop();
        }
    }
}