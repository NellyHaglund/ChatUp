using System;
using System.ServiceModel;
using System.Windows.Forms;
using ChatUpWinFormClient.ServiceReferenceChatUp;

namespace ChatUpWinFormClient.Forms
{
    public partial class AllChatRoomForm : Form
    {
        private readonly string _userName;
        private readonly int _chatRoomId;
        private readonly ChatServiceClient _client;

        public AllChatRoomForm(string userName)
        {
            InitializeComponent();
            _userName = userName;
            labelLoggedInAll.Text = $"Logged in as: {_userName}";
            _chatRoomId = 3;
            _client = new ChatServiceClient("All");

            UpdateTexts();
            var timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += (sender, args) => UpdateTexts();
            timer.Start();
        }

        private void buttonSendMessageAll_Click(object sender, EventArgs e)
        {
            try
            {
                var post = new CustomPost
                {
                    Submitter = _userName,
                    TimeSubmitted = DateTime.Now,
                    Comment = richTextBoxMessageAll.Text,
                    ChatRoomId = 3
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

        private void buttonUpdateAll_Click(object sender, EventArgs e)
        {
            UpdateTexts();
        }

        private void UpdateTexts()
        {
            listViewMessageAll.Clear();
            var result = _client.GetPosts(3);
            foreach (var customPost in result)
            {
                listViewMessageAll.Items.Add(
                    $"{customPost.Submitter} {customPost.TimeSubmitted}\r\n {customPost.Comment}:");
            }
            listViewMessageAll.Items[listViewMessageAll.Items.Count - 1].EnsureVisible();
        }
    }
}