namespace ChatUpWinFormClient.Forms
{
    partial class AllChatRoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLoggedInAll = new System.Windows.Forms.Label();
            this.buttonSendMessageAll = new System.Windows.Forms.Button();
            this.richTextBoxMessageAll = new System.Windows.Forms.RichTextBox();
            this.listViewMessageAll = new System.Windows.Forms.ListView();
            this.buttonRemovePost = new System.Windows.Forms.Button();
            this.lblTextCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLoggedInAll
            // 
            this.labelLoggedInAll.AutoSize = true;
            this.labelLoggedInAll.ForeColor = System.Drawing.Color.White;
            this.labelLoggedInAll.Location = new System.Drawing.Point(13, 9);
            this.labelLoggedInAll.Name = "labelLoggedInAll";
            this.labelLoggedInAll.Size = new System.Drawing.Size(46, 17);
            this.labelLoggedInAll.TabIndex = 7;
            this.labelLoggedInAll.Text = "label1";
            // 
            // buttonSendMessageAll
            // 
            this.buttonSendMessageAll.BackColor = System.Drawing.Color.Gray;
            this.buttonSendMessageAll.Location = new System.Drawing.Point(478, 335);
            this.buttonSendMessageAll.Name = "buttonSendMessageAll";
            this.buttonSendMessageAll.Size = new System.Drawing.Size(139, 123);
            this.buttonSendMessageAll.TabIndex = 6;
            this.buttonSendMessageAll.Text = "Send message";
            this.buttonSendMessageAll.UseVisualStyleBackColor = false;
            this.buttonSendMessageAll.Click += new System.EventHandler(this.buttonSendMessageAll_Click);
            // 
            // richTextBoxMessageAll
            // 
            this.richTextBoxMessageAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBoxMessageAll.Location = new System.Drawing.Point(12, 335);
            this.richTextBoxMessageAll.MaxLength = 55;
            this.richTextBoxMessageAll.Name = "richTextBoxMessageAll";
            this.richTextBoxMessageAll.Size = new System.Drawing.Size(460, 123);
            this.richTextBoxMessageAll.TabIndex = 5;
            this.richTextBoxMessageAll.Text = "";
            this.richTextBoxMessageAll.TextChanged += new System.EventHandler(this.richTextBoxMessageAll_TextChanged);
            // 
            // listViewMessageAll
            // 
            this.listViewMessageAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listViewMessageAll.LabelWrap = false;
            this.listViewMessageAll.Location = new System.Drawing.Point(12, 32);
            this.listViewMessageAll.MultiSelect = false;
            this.listViewMessageAll.Name = "listViewMessageAll";
            this.listViewMessageAll.Size = new System.Drawing.Size(605, 283);
            this.listViewMessageAll.TabIndex = 4;
            this.listViewMessageAll.TileSize = new System.Drawing.Size(360, 36);
            this.listViewMessageAll.UseCompatibleStateImageBehavior = false;
            this.listViewMessageAll.View = System.Windows.Forms.View.Tile;
            this.listViewMessageAll.SelectedIndexChanged += new System.EventHandler(this.listViewMessageAll_SelectedIndexChanged);
            // 
            // buttonRemovePost
            // 
            this.buttonRemovePost.BackColor = System.Drawing.Color.Gray;
            this.buttonRemovePost.Location = new System.Drawing.Point(479, 2);
            this.buttonRemovePost.Name = "buttonRemovePost";
            this.buttonRemovePost.Size = new System.Drawing.Size(137, 23);
            this.buttonRemovePost.TabIndex = 9;
            this.buttonRemovePost.Text = "Remove Post";
            this.buttonRemovePost.UseVisualStyleBackColor = false;
            this.buttonRemovePost.Click += new System.EventHandler(this.buttonRemovePost_Click);
            // 
            // lblTextCounter
            // 
            this.lblTextCounter.AutoSize = true;
            this.lblTextCounter.BackColor = System.Drawing.Color.LightGray;
            this.lblTextCounter.Location = new System.Drawing.Point(448, 441);
            this.lblTextCounter.Name = "lblTextCounter";
            this.lblTextCounter.Size = new System.Drawing.Size(24, 17);
            this.lblTextCounter.TabIndex = 10;
            this.lblTextCounter.Text = "55";
            // 
            // AllChatRoomForm
            // 
            this.AcceptButton = this.buttonSendMessageAll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(629, 467);
            this.Controls.Add(this.lblTextCounter);
            this.Controls.Add(this.buttonRemovePost);
            this.Controls.Add(this.labelLoggedInAll);
            this.Controls.Add(this.buttonSendMessageAll);
            this.Controls.Add(this.richTextBoxMessageAll);
            this.Controls.Add(this.listViewMessageAll);
            this.MaximumSize = new System.Drawing.Size(647, 514);
            this.MinimumSize = new System.Drawing.Size(647, 514);
            this.Name = "AllChatRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "All chat room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoggedInAll;
        private System.Windows.Forms.Button buttonSendMessageAll;
        private System.Windows.Forms.RichTextBox richTextBoxMessageAll;
        private System.Windows.Forms.ListView listViewMessageAll;
        private System.Windows.Forms.Button buttonRemovePost;
        private System.Windows.Forms.Label lblTextCounter;
    }
}