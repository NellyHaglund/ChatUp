﻿namespace ChatUpWinFormClient.Forms
{
    partial class WomenChatRoomForm
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
            this.listViewMessageBoudoir = new System.Windows.Forms.ListView();
            this.richTextBoxMessageBoudoir = new System.Windows.Forms.RichTextBox();
            this.buttonSendMessageBoudoir = new System.Windows.Forms.Button();
            this.labelLoggedInMen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewMessageBoudoir
            // 
            this.listViewMessageBoudoir.LabelWrap = false;
            this.listViewMessageBoudoir.Location = new System.Drawing.Point(12, 29);
            this.listViewMessageBoudoir.MultiSelect = false;
            this.listViewMessageBoudoir.Name = "listViewMessageBoudoir";
            this.listViewMessageBoudoir.Size = new System.Drawing.Size(605, 283);
            this.listViewMessageBoudoir.TabIndex = 0;
            this.listViewMessageBoudoir.TileSize = new System.Drawing.Size(360, 36);
            this.listViewMessageBoudoir.UseCompatibleStateImageBehavior = false;
            this.listViewMessageBoudoir.View = System.Windows.Forms.View.Tile;
            // 
            // richTextBoxMessageBoudoir
            // 
            this.richTextBoxMessageBoudoir.Location = new System.Drawing.Point(12, 332);
            this.richTextBoxMessageBoudoir.Name = "richTextBoxMessageBoudoir";
            this.richTextBoxMessageBoudoir.Size = new System.Drawing.Size(460, 123);
            this.richTextBoxMessageBoudoir.TabIndex = 1;
            this.richTextBoxMessageBoudoir.Text = "";
            // 
            // buttonSendMessageBoudoir
            // 
            this.buttonSendMessageBoudoir.Location = new System.Drawing.Point(478, 384);
            this.buttonSendMessageBoudoir.Name = "buttonSendMessageBoudoir";
            this.buttonSendMessageBoudoir.Size = new System.Drawing.Size(139, 29);
            this.buttonSendMessageBoudoir.TabIndex = 2;
            this.buttonSendMessageBoudoir.Text = "Send message";
            this.buttonSendMessageBoudoir.UseVisualStyleBackColor = true;
            this.buttonSendMessageBoudoir.Click += new System.EventHandler(this.buttonSendMessageBoudoir_Click);
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
            // WomenChatRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 467);
            this.Controls.Add(this.labelLoggedInMen);
            this.Controls.Add(this.buttonSendMessageBoudoir);
            this.Controls.Add(this.richTextBoxMessageBoudoir);
            this.Controls.Add(this.listViewMessageBoudoir);
            this.Name = "WomenChatRoomForm";
            this.Text = "Boudoir chat room";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMessageBoudoir;
        private System.Windows.Forms.RichTextBox richTextBoxMessageBoudoir;
        private System.Windows.Forms.Button buttonSendMessageBoudoir;
        private System.Windows.Forms.Label labelLoggedInMen;
    }
}