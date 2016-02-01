namespace ChatUpWinFormClient.Forms
{
    partial class MenChatRoomForm
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
            this.listViewMessageMen = new System.Windows.Forms.ListView();
            this.richTextBoxMessageMen = new System.Windows.Forms.RichTextBox();
            this.buttonSendMessageMen = new System.Windows.Forms.Button();
            this.labelLoggedInMen = new System.Windows.Forms.Label();
            this.buttonRemovePost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewMessageMen
            // 
            this.listViewMessageMen.LabelWrap = false;
            this.listViewMessageMen.Location = new System.Drawing.Point(12, 32);
            this.listViewMessageMen.MultiSelect = false;
            this.listViewMessageMen.Name = "listViewMessageMen";
            this.listViewMessageMen.Size = new System.Drawing.Size(605, 283);
            this.listViewMessageMen.TabIndex = 0;
            this.listViewMessageMen.TileSize = new System.Drawing.Size(360, 36);
            this.listViewMessageMen.UseCompatibleStateImageBehavior = false;
            this.listViewMessageMen.View = System.Windows.Forms.View.Tile;
            // 
            // richTextBoxMessageMen
            // 
            this.richTextBoxMessageMen.Location = new System.Drawing.Point(12, 335);
            this.richTextBoxMessageMen.Name = "richTextBoxMessageMen";
            this.richTextBoxMessageMen.Size = new System.Drawing.Size(460, 123);
            this.richTextBoxMessageMen.TabIndex = 1;
            this.richTextBoxMessageMen.Text = "";
            // 
            // buttonSendMessageMen
            // 
            this.buttonSendMessageMen.Location = new System.Drawing.Point(478, 387);
            this.buttonSendMessageMen.Name = "buttonSendMessageMen";
            this.buttonSendMessageMen.Size = new System.Drawing.Size(139, 29);
            this.buttonSendMessageMen.TabIndex = 2;
            this.buttonSendMessageMen.Text = "Send message";
            this.buttonSendMessageMen.UseVisualStyleBackColor = true;
            this.buttonSendMessageMen.Click += new System.EventHandler(this.buttonSendMessageMen_Click);
            // 
            // labelLoggedInMen
            // 
            this.labelLoggedInMen.AutoSize = true;
            this.labelLoggedInMen.Location = new System.Drawing.Point(13, 9);
            this.labelLoggedInMen.Name = "labelLoggedInMen";
            this.labelLoggedInMen.Size = new System.Drawing.Size(46, 17);
            this.labelLoggedInMen.TabIndex = 3;
            this.labelLoggedInMen.Text = "label1";
            // 
            // buttonRemovePost
            // 
            this.buttonRemovePost.Location = new System.Drawing.Point(479, 2);
            this.buttonRemovePost.Name = "buttonRemovePost";
            this.buttonRemovePost.Size = new System.Drawing.Size(137, 23);
            this.buttonRemovePost.TabIndex = 9;
            this.buttonRemovePost.Text = "Remove Post";
            this.buttonRemovePost.UseVisualStyleBackColor = true;
            this.buttonRemovePost.Click += new System.EventHandler(this.buttonRemovePost_Click);
            // 
            // MenChatRoomForm
            // 
            this.AcceptButton = this.buttonSendMessageMen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 467);
            this.Controls.Add(this.buttonRemovePost);
            this.Controls.Add(this.labelLoggedInMen);
            this.Controls.Add(this.buttonSendMessageMen);
            this.Controls.Add(this.richTextBoxMessageMen);
            this.Controls.Add(this.listViewMessageMen);
            this.Name = "MenChatRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Man cave chat room";
            this.Load += new System.EventHandler(this.MenChatRoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMessageMen;
        private System.Windows.Forms.RichTextBox richTextBoxMessageMen;
        private System.Windows.Forms.Button buttonSendMessageMen;
        private System.Windows.Forms.Label labelLoggedInMen;
        private System.Windows.Forms.Button buttonRemovePost;
    }
}