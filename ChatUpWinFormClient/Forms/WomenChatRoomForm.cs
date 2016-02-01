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

        public WomenChatRoomForm(string userName)
        {
            InitializeComponent();
            _userName = userName;
            labelLoggedInWomen.Text = $"Logged in as: {_userName}";
            _chatRoomId = 2;
            _client = new ChatServiceClient("All");

            UpdateTexts();
            var timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += (sender, args) => UpdateTexts();
            timer.Start();
        }

        private void UpdateTexts()
        {
            listViewMessageBoudoir.Clear();
            var result = _client.GetPosts(_chatRoomId);
            foreach (var customPost in result)
            {
                ListViewItem item = new ListViewItem();
                item.Name = customPost.Id.ToString();
                item.Text = $"{customPost.Submitter} {customPost.TimeSubmitted} {customPost.Comment}";
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
            //REMOVECLICKEVENT
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
                MessageBox.Show("Choose a post to remove.");
            }
        }
    }
}