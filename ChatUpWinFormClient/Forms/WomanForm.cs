using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatUpWinFormClient.Forms
{
    public partial class WomanForm : Form
    {
        private string _userName;
        public WomanForm(string userName)
        {
            _userName = userName;
            InitializeComponent();
            labelWelcome.Text = $"Welcome {userName}!\r\nYou are now logged in!\r\nChoose a chat room to start chatting";
        }

        private void buttonManToWoman_Click(object sender, EventArgs e)
        {
            AllChatRoomForm allChatRoomForm = new AllChatRoomForm(_userName);
            allChatRoomForm.ShowDialog();
            //this.Enabled = false;
        }

        private void buttonWomanToWoman_Click(object sender, EventArgs e)
        {
            WomenChatRoomForm womenChatRoomForm = new WomenChatRoomForm(_userName);
            womenChatRoomForm.ShowDialog();
            //this.Enabled = false;
        }
    }
}
