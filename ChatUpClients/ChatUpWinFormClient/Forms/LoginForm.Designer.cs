namespace ChatUpWinFormClient
{
    partial class LoginForm
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
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelRadioButtons = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(6, 3);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(56, 21);
            this.radioButtonMan.TabIndex = 0;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "Man";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            this.radioButtonMan.CheckedChanged += new System.EventHandler(this.radioButtonMan_CheckedChanged);
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Location = new System.Drawing.Point(6, 30);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(77, 21);
            this.radioButtonWoman.TabIndex = 1;
            this.radioButtonWoman.TabStop = true;
            this.radioButtonWoman.Text = "Woman";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            this.radioButtonWoman.CheckedChanged += new System.EventHandler(this.radioButtonWoman_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gender";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(57, 85);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(160, 22);
            this.textBoxUserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Enabled = false;
            this.buttonLogin.Location = new System.Drawing.Point(57, 213);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(127, 38);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelRadioButtons
            // 
            this.panelRadioButtons.Controls.Add(this.radioButtonWoman);
            this.panelRadioButtons.Controls.Add(this.radioButtonMan);
            this.panelRadioButtons.Location = new System.Drawing.Point(57, 143);
            this.panelRadioButtons.Name = "panelRadioButtons";
            this.panelRadioButtons.Size = new System.Drawing.Size(84, 55);
            this.panelRadioButtons.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login to start chatting";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 301);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelRadioButtons);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatUp Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelRadioButtons.ResumeLayout(false);
            this.panelRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelRadioButtons;
        private System.Windows.Forms.Label label3;
    }
}

