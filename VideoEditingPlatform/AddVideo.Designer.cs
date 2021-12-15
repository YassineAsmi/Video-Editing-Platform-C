
using System;

namespace VideoEditingPlatform
{
    partial class AddVideo
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
            this.gradientColor1 = new VideoEditingPlatform.GradientColor();
            this.DeadLineAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientNameAdd = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SongAdd = new System.Windows.Forms.TextBox();
            this.VideoNameAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltxt = new System.Windows.Forms.Label();
            this.gradientColor1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientColor1
            // 
            this.gradientColor1.Angle = 0F;
            this.gradientColor1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.gradientColor1.Controls.Add(this.DeadLineAdd);
            this.gradientColor1.Controls.Add(this.label1);
            this.gradientColor1.Controls.Add(this.ClientNameAdd);
            this.gradientColor1.Controls.Add(this.button2);
            this.gradientColor1.Controls.Add(this.btnSave);
            this.gradientColor1.Controls.Add(this.SongAdd);
            this.gradientColor1.Controls.Add(this.VideoNameAdd);
            this.gradientColor1.Controls.Add(this.label4);
            this.gradientColor1.Controls.Add(this.label3);
            this.gradientColor1.Controls.Add(this.label2);
            this.gradientColor1.Controls.Add(this.lbltxt);
            this.gradientColor1.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gradientColor1.Location = new System.Drawing.Point(0, 1);
            this.gradientColor1.Name = "gradientColor1";
            this.gradientColor1.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.gradientColor1.Size = new System.Drawing.Size(653, 585);
            this.gradientColor1.TabIndex = 1;
            this.gradientColor1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            // 
            // DeadLineAdd
            // 
            this.DeadLineAdd.BackColor = System.Drawing.Color.White;
            this.DeadLineAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeadLineAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DeadLineAdd.ForeColor = System.Drawing.Color.Black;
            this.DeadLineAdd.Location = new System.Drawing.Point(261, 275);
            this.DeadLineAdd.MaximumSize = new System.Drawing.Size(200, 200);
            this.DeadLineAdd.Multiline = true;
            this.DeadLineAdd.Name = "DeadLineAdd";
            this.DeadLineAdd.Size = new System.Drawing.Size(200, 29);
            this.DeadLineAdd.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 45);
            this.label1.TabIndex = 35;
            this.label1.Text = "Client Name :";
            // 
            // ClientNameAdd
            // 
            this.ClientNameAdd.FormattingEnabled = true;
            this.ClientNameAdd.Location = new System.Drawing.Point(261, 136);
            this.ClientNameAdd.Name = "ClientNameAdd";
            this.ClientNameAdd.Size = new System.Drawing.Size(200, 21);
            this.ClientNameAdd.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(375, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 58);
            this.button2.TabIndex = 33;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(102, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 58);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SongAdd
            // 
            this.SongAdd.BackColor = System.Drawing.Color.White;
            this.SongAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SongAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SongAdd.ForeColor = System.Drawing.Color.Black;
            this.SongAdd.Location = new System.Drawing.Point(261, 351);
            this.SongAdd.MaximumSize = new System.Drawing.Size(200, 200);
            this.SongAdd.Multiline = true;
            this.SongAdd.Name = "SongAdd";
            this.SongAdd.Size = new System.Drawing.Size(200, 29);
            this.SongAdd.TabIndex = 31;
            // 
            // VideoNameAdd
            // 
            this.VideoNameAdd.BackColor = System.Drawing.Color.White;
            this.VideoNameAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VideoNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.VideoNameAdd.ForeColor = System.Drawing.Color.Black;
            this.VideoNameAdd.Location = new System.Drawing.Point(261, 203);
            this.VideoNameAdd.MaximumSize = new System.Drawing.Size(200, 200);
            this.VideoNameAdd.Multiline = true;
            this.VideoNameAdd.Name = "VideoNameAdd";
            this.VideoNameAdd.Size = new System.Drawing.Size(200, 29);
            this.VideoNameAdd.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(109, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 45);
            this.label4.TabIndex = 16;
            this.label4.Text = "Song :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(47, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 45);
            this.label3.TabIndex = 15;
            this.label3.Text = "DeadLine :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(2, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 45);
            this.label2.TabIndex = 14;
            this.label2.Text = "Video Name :";
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.BackColor = System.Drawing.Color.Transparent;
            this.lbltxt.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt.ForeColor = System.Drawing.Color.White;
            this.lbltxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbltxt.Location = new System.Drawing.Point(173, 23);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(287, 65);
            this.lbltxt.TabIndex = 13;
            this.lbltxt.Text = "Add Videos";
            this.lbltxt.Click += new System.EventHandler(this.lbltxt_Click);
            // 
            // AddVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 594);
            this.Controls.Add(this.gradientColor1);
            this.Name = "AddVideo";
            this.Text = "AddVideo";
            this.Load += new System.EventHandler(this.AddVideo_Load);
            this.Shown += new System.EventHandler(this.AddVideo_Shown);
            this.gradientColor1.ResumeLayout(false);
            this.gradientColor1.PerformLayout();
            this.ResumeLayout(false);

        }

  
        #endregion

        private GradientColor gradientColor1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox SongAdd;
        private System.Windows.Forms.TextBox VideoNameAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.ComboBox ClientNameAdd;
        private System.Windows.Forms.TextBox DeadLineAdd;
        private System.Windows.Forms.Label label1;
    }
}