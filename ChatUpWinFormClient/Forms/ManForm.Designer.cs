namespace ChatUpWinFormClient.Forms
{
    partial class ManForm
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonManToWoman = new System.Windows.Forms.Button();
            this.buttonManToMan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(138, 23);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(0, 25);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chat room for men";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chat room for all";
            // 
            // buttonManToWoman
            // 
            this.buttonManToWoman.BackgroundImage = global::ChatUpWinFormClient.Properties.Resources.tdy_130221_woman_talking_830a_vmodv4;
            this.buttonManToWoman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonManToWoman.Location = new System.Drawing.Point(343, 201);
            this.buttonManToWoman.Name = "buttonManToWoman";
            this.buttonManToWoman.Size = new System.Drawing.Size(316, 227);
            this.buttonManToWoman.TabIndex = 3;
            this.buttonManToWoman.UseVisualStyleBackColor = true;
            this.buttonManToWoman.Click += new System.EventHandler(this.buttonManToWoman_Click);
            // 
            // buttonManToMan
            // 
            this.buttonManToMan.BackgroundImage = global::ChatUpWinFormClient.Properties.Resources.man_cave_warning;
            this.buttonManToMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonManToMan.Location = new System.Drawing.Point(12, 201);
            this.buttonManToMan.Name = "buttonManToMan";
            this.buttonManToMan.Size = new System.Drawing.Size(316, 227);
            this.buttonManToMan.TabIndex = 0;
            this.buttonManToMan.UseVisualStyleBackColor = true;
            this.buttonManToMan.Click += new System.EventHandler(this.buttonManToMan_Click);
            // 
            // ManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 515);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonManToWoman);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonManToMan);
            this.MaximumSize = new System.Drawing.Size(689, 562);
            this.MinimumSize = new System.Drawing.Size(689, 562);
            this.Name = "ManForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManForm";
            this.Load += new System.EventHandler(this.ManForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonManToMan;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonManToWoman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}