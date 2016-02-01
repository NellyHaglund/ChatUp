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
    public partial class MenChatRoomForm : Form
    {
        public MenChatRoomForm(string userName)
        {
            InitializeComponent();
            labelLoggedInMen.Text = $"Logged in as: {userName}";
        }

        private void MenChatRoomForm_Load(object sender, EventArgs e)
        {

        }
    }
}
