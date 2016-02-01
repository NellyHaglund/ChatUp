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
            this.buttonUpdateAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLoggedInAll
            // 
            this.labelLoggedInAll.AutoSize = true;
            this.labelLoggedInAll.Location = new System.Drawing.Point(13, 9);
            this.labelLoggedInAll.Name = "labelLoggedInAll";
            this.labelLoggedInAll.Size = new System.Drawing.Size(46, 17);
            this.labelLoggedInAll.TabIndex = 7;
            this.labelLoggedInAll.Text = "label1";
            // 
            // buttonSendMessageAll
            // 
            this.buttonSendMessageAll.Location = new System.Drawing.Point(478, 387);
            this.buttonSendMessageAll.Name = "buttonSendMessageAll";
            this.buttonSendMessageAll.Size = new System.Drawing.Size(139, 29);
            this.buttonSendMessageAll.TabIndex = 6;
            this.buttonSendMessageAll.Text = "Send message";
            this.buttonSendMessageAll.UseVisualStyleBackColor = true;
            this.buttonSendMessageAll.Click += new System.EventHandler(this.buttonSendMessageAll_Click);
            // 
            // richTextBoxMessageAll
            // 
            this.richTextBoxMessageAll.Location = new System.Drawing.Point(12, 335);
            this.richTextBoxMessageAll.Name = "richTextBoxMessageAll";
            this.richTextBoxMessageAll.Size = new System.Drawing.Size(460, 123);
            this.richTextBoxMessageAll.TabIndex = 5;
            this.richTextBoxMessageAll.Text = "";
            // 
            // listViewMessageAll
            // 
            this.listViewMessageAll.BackColor = System.Drawing.SystemColors.Window;
            this.listViewMessageAll.LabelWrap = false;
            this.listViewMessageAll.Location = new System.Drawing.Point(12, 32);
            this.listViewMessageAll.MultiSelect = false;
            this.listViewMessageAll.Name = "listViewMessageAll";
            this.listViewMessageAll.Size = new System.Drawing.Size(605, 283);
            this.listViewMessageAll.TabIndex = 4;
            this.listViewMessageAll.TileSize = new System.Drawing.Size(360, 36);
            this.listViewMessageAll.UseCompatibleStateImageBehavior = false;
            this.listViewMessageAll.View = System.Windows.Forms.View.Tile;
            // 
            // buttonUpdateAll
            // 
            this.buttonUpdateAll.Location = new System.Drawing.Point(479, 335);
            this.buttonUpdateAll.Name = "buttonUpdateAll";
            this.buttonUpdateAll.Size = new System.Drawing.Size(138, 27);
            this.buttonUpdateAll.TabIndex = 8;
            this.buttonUpdateAll.Text = "Update";
            this.buttonUpdateAll.UseVisualStyleBackColor = true;
            this.buttonUpdateAll.Visible = false;
            this.buttonUpdateAll.Click += new System.EventHandler(this.buttonUpdateAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Remove Post";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllChatRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUpdateAll);
            this.Controls.Add(this.labelLoggedInAll);
            this.Controls.Add(this.buttonSendMessageAll);
            this.Controls.Add(this.richTextBoxMessageAll);
            this.Controls.Add(this.listViewMessageAll);
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
        private System.Windows.Forms.Button buttonUpdateAll;
        private System.Windows.Forms.Button button1;
    }
}