﻿
namespace VideoEditingPlatform
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.passLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\Work\\logoblack.png";
            this.pictureBox1.Location = new System.Drawing.Point(598, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.Snow;
            this.Loginbtn.Location = new System.Drawing.Point(471, 524);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(202, 43);
            this.Loginbtn.TabIndex = 1;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(765, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // userLogin
            // 
            this.userLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userLogin.BackColor = System.Drawing.Color.White;
            this.userLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.userLogin.Location = new System.Drawing.Point(471, 312);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(500, 31);
            this.userLogin.TabIndex = 6;
            this.userLogin.Text = "UserName";
            this.userLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // passLogin
            // 
            this.passLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.passLogin.Location = new System.Drawing.Point(471, 414);
            this.passLogin.Name = "passLogin";
            this.passLogin.Size = new System.Drawing.Size(500, 31);
            this.passLogin.TabIndex = 7;
            this.passLogin.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1387, 620);
            this.Controls.Add(this.passLogin);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Video Editing Platform";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.TextBox passLogin;
    }
}

