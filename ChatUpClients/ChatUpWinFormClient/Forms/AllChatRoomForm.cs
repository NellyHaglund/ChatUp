using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatUpWinFormClient.ServiceReferenceChatUp;

namespace ChatUpWinFormClient.Forms
{
    public partial class AllChatRoomForm : Form
    {
        private readonly string _userName;
        public AllChatRoomForm(string userName)
        {
            InitializeComponent();
            _userName = userName;
            labelLoggedInAll.Text = $"Logged in as: {_userName}";
        }

        private void buttonSendMessageAll_Click(object sender, EventArgs e)
        {
            ChatServiceClient client = new ChatServiceClient("All");
            CustomPost post = new CustomPost
            {
                Submitter = _userName,
                TimeSubmitted = DateTime.Now,
                Comment = richTextBoxMessageAll.Text,
                ChatRoomId = 3
            };
            client.SubmitPost(post);
            richTextBoxMessageAll.Clear();
            UpdateTexts();
        }

        private void buttonUpdateAll_Click(object sender, EventArgs e)
        {
            UpdateTexts();
        }

        private void UpdateTexts()
        {
            listViewMessageAll.Clear();
            ServiceReferenceChatUp.ChatServiceClient client = new ChatServiceClient("All");
            var result = client.GetPosts(3);
            foreach (var customPost in result)
            {
                listViewMessageAll.Items.Add($"{customPost.Submitter} {customPost.TimeSubmitted}\r\n {customPost.Comment}:");
                
            }
        }
    }
}
