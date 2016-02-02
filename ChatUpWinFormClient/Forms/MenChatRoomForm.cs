﻿using System;
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
            labelLoggedInMen.Text = $"Logged in as: {_userName}";
            _chatRoomId = 1;
            _client = new ChatServiceClient("ManCave");
            UpdateTexts();
            var timer = new Timer();
            timer.Interval = 3000;
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
                //Här vill vi nog inte visa exception.Message, för då får användaren detta i en MessageBox: 
                //"Ett fel inträffande under mottagning av http-svaret till http://localhost:20276/ChatService.svc/Man. Det kan bero på att //tjänstens slutpunktsbindning inte använder http-protokollet. Det kan också bero på att en kontext för http-begäran har avbrutits av servern (troligtvis på grund av att tjänsten avslutas). Du hittar mer information i serverloggarna."
                //Kanske bara ska stå typ "ett fel inträffade" eller något
                MessageBox.Show(exception.Message);
            }
        }
        private void UpdateTexts()
        {
            listViewMessageMen.Clear();
            var result = _client.GetPosts(_chatRoomId);
            foreach (var customPost in result)
            {
                ListViewItem item = new ListViewItem();
                item.Name = customPost.Id.ToString();
                item.Text = $"{customPost.Submitter} {customPost.TimeSubmitted} {customPost.Comment}";
                listViewMessageMen.Items.Add(item);
            }
            listViewMessageMen.Items[listViewMessageMen.Items.Count - 1].EnsureVisible();
        }

        private void buttonRemovePost_Click(object sender, EventArgs e)
        {
            //REMOVECLICKEVENT
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
        }
    }
}
