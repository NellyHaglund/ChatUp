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
            this.SuspendLayout();
            // 
            // listViewMessageMen
            // 
            this.listViewMessageMen.Location = new System.Drawing.Point(12, 29);
            this.listViewMessageMen.Name = "listViewMessageMen";
            this.listViewMessageMen.Size = new System.Drawing.Size(605, 283);
            this.listViewMessageMen.TabIndex = 0;
            this.listViewMessageMen.UseCompatibleStateImageBehavior = false;
            // 
            // richTextBoxMessageMen
            // 
            this.richTextBoxMessageMen.Location = new System.Drawing.Point(12, 332);
            this.richTextBoxMessageMen.Name = "richTextBoxMessageMen";
            this.richTextBoxMessageMen.Size = new System.Drawing.Size(460, 123);
            this.richTextBoxMessageMen.TabIndex = 1;
            this.richTextBoxMessageMen.Text = "";
            // 
            // buttonSendMessageMen
            // 
            this.buttonSendMessageMen.Location = new System.Drawing.Point(478, 384);
            this.buttonSendMessageMen.Name = "buttonSendMessageMen";
            this.buttonSendMessageMen.Size = new System.Drawing.Size(139, 29);
            this.buttonSendMessageMen.TabIndex = 2;
            this.buttonSendMessageMen.Text = "Send message";
            this.buttonSendMessageMen.UseVisualStyleBackColor = true;
            // 
            // labelLoggedInMen
            // 
            this.labelLoggedInMen.AutoSize = true;
            this.labelLoggedInMen.Location = new System.Drawing.Point(13, 6);
            this.labelLoggedInMen.Name = "labelLoggedInMen";
            this.labelLoggedInMen.Size = new System.Drawing.Size(46, 17);
            this.labelLoggedInMen.TabIndex = 3;
            this.labelLoggedInMen.Text = "label1";
            // 
            // MenChatRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 467);
            this.Controls.Add(this.labelLoggedInMen);
            this.Controls.Add(this.buttonSendMessageMen);
            this.Controls.Add(this.richTextBoxMessageMen);
            this.Controls.Add(this.listViewMessageMen);
            this.Name = "MenChatRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Man cave chat room";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MenChatRoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMessageMen;
        private System.Windows.Forms.RichTextBox richTextBoxMessageMen;
        private System.Windows.Forms.Button buttonSendMessageMen;
        private System.Windows.Forms.Label labelLoggedInMen;
    }
}