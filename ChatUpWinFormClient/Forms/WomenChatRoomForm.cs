using System;
using System.ServiceModel;
using System.Windows.Forms;
using ChatUpWinFormClient.ServiceReferenceChatUp;

namespace ChatUpWinFormClient.Forms
{
    public partial class WomenChatRoomForm : Form
    {
        private readonly int _chatRoomId;
        private readonly ChatServiceClient _client;
        private readonly string _userName;

        public WomenChatRoomForm(string userName)
        {
            InitializeComponent();
            _userName = userName;
            labelLoggedInMen.Text = $"Logged in as: {userName}";
            _chatRoomId = 2;
            _client = new ChatServiceClient("Boudoir");

            UpdateTexts();
            var timer = new Timer {Interval = 3000};
            timer.Tick += (sender, args) => UpdateTexts();
            timer.Start();
        }

        private void UpdateTexts()
        {
            listViewMessageBoudoir.Clear();
            var result = _client.GetPosts(_chatRoomId);
            foreach (var customPost in result)
            {
                listViewMessageBoudoir.Items.Add(
                    $"{customPost.Submitter} {customPost.TimeSubmitted}\r\n {customPost.Comment}:");
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
                    ChatRoomId = _chatRoomId
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
    }
}