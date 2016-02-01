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
using ChatUpWinFormClient.ServiceReferenceChatUp;

namespace ChatUpWinFormClient.Forms
{
    public partial class MenChatRoomForm : Form
    {
        private readonly string _userName;
        private readonly int _chatRoomId;
        private readonly ChatServiceClient _client;

        public MenChatRoomForm(string userName)
        {
            InitializeComponent();
            _userName = userName;
            labelLoggedInMen.Text = $"Logged in as: {userName}";
            _chatRoomId = 1;
            _client = new ChatServiceClient("ManCave");
            UpdateTexts();
            var timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, args) => UpdateTexts();
            timer.Start();
        }

        private void MenChatRoomForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSendMessageMen_Click(object sender, EventArgs e)
        {
            try
            {
                var post = new CustomPost
                {
                    Submitter = _userName,
                    TimeSubmitted = DateTime.Now,
                    Comment = richTextBoxMessageMen.Text,
                    ChatRoomId = _chatRoomId
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
                listViewMessageMen.Items.Add(
                    $"{customPost.Submitter} {customPost.TimeSubmitted} {customPost.Comment}");
            }
            listViewMessageMen.Items[listViewMessageMen.Items.Count - 1].EnsureVisible();
        }
    }
}
