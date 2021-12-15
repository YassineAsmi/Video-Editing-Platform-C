
namespace VideoEditingPlatform
{
    partial class EditVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditVideo));
            this.gradientColor1 = new VideoEditingPlatform.GradientColor();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusEdit = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.DeadLineEdit = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SongEdit = new System.Windows.Forms.TextBox();
            this.VideoNameEdit = new System.Windows.Forms.TextBox();
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
            this.gradientColor1.Controls.Add(this.label1);
            this.gradientColor1.Controls.Add(this.StatusEdit);
            this.gradientColor1.Controls.Add(this.DeadLineEdit);
            this.gradientColor1.Controls.Add(this.button2);
            this.gradientColor1.Controls.Add(this.btnSave);
            this.gradientColor1.Controls.Add(this.SongEdit);
            this.gradientColor1.Controls.Add(this.VideoNameEdit);
            this.gradientColor1.Controls.Add(this.label4);
            this.gradientColor1.Controls.Add(this.label3);
            this.gradientColor1.Controls.Add(this.label2);
            this.gradientColor1.Controls.Add(this.lbltxt);
            this.gradientColor1.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gradientColor1.Location = new System.Drawing.Point(1, 1);
            this.gradientColor1.Name = "gradientColor1";
            this.gradientColor1.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.gradientColor1.Size = new System.Drawing.Size(653, 585);
            this.gradientColor1.TabIndex = 2;
            this.gradientColor1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(103, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 45);
            this.label1.TabIndex = 38;
            this.label1.Text = "Status :";
            // 
            // StatusEdit
            // 
            this.StatusEdit.AllowBindingControlAnimation = true;
            this.StatusEdit.AllowBindingControlColorChanges = false;
            this.StatusEdit.AllowBindingControlLocation = true;
            this.StatusEdit.AllowCheckBoxAnimation = false;
            this.StatusEdit.AllowCheckmarkAnimation = true;
            this.StatusEdit.AllowOnHoverStates = true;
            this.StatusEdit.AutoCheck = true;
            this.StatusEdit.BackColor = System.Drawing.Color.Transparent;
            this.StatusEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StatusEdit.BackgroundImage")));
            this.StatusEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StatusEdit.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.StatusEdit.BorderRadius = 12;
            this.StatusEdit.Checked = true;
            this.StatusEdit.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.StatusEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.StatusEdit.CustomCheckmarkImage = null;
            this.StatusEdit.Location = new System.Drawing.Point(350, 355);
            this.StatusEdit.MinimumSize = new System.Drawing.Size(17, 17);
            this.StatusEdit.Name = "StatusEdit";
            this.StatusEdit.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.StatusEdit.OnCheck.BorderRadius = 12;
            this.StatusEdit.OnCheck.BorderThickness = 2;
            this.StatusEdit.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.StatusEdit.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.StatusEdit.OnCheck.CheckmarkThickness = 2;
            this.StatusEdit.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.StatusEdit.OnDisable.BorderRadius = 12;
            this.StatusEdit.OnDisable.BorderThickness = 2;
            this.StatusEdit.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.StatusEdit.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.StatusEdit.OnDisable.CheckmarkThickness = 2;
            this.StatusEdit.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.StatusEdit.OnHoverChecked.BorderRadius = 12;
            this.StatusEdit.OnHoverChecked.BorderThickness = 2;
            this.StatusEdit.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.StatusEdit.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.StatusEdit.OnHoverChecked.CheckmarkThickness = 2;
            this.StatusEdit.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.StatusEdit.OnHoverUnchecked.BorderRadius = 12;
            this.StatusEdit.OnHoverUnchecked.BorderThickness = 1;
            this.StatusEdit.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.StatusEdit.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.StatusEdit.OnUncheck.BorderRadius = 12;
            this.StatusEdit.OnUncheck.BorderThickness = 1;
            this.StatusEdit.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.StatusEdit.Size = new System.Drawing.Size(27, 27);
            this.StatusEdit.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.StatusEdit.TabIndex = 37;
            this.StatusEdit.ThreeState = false;
            this.StatusEdit.ToolTipText = null;
            // 
            // DeadLineEdit
            // 
            this.DeadLineEdit.BackColor = System.Drawing.Color.White;
            this.DeadLineEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeadLineEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DeadLineEdit.ForeColor = System.Drawing.Color.Black;
            this.DeadLineEdit.Location = new System.Drawing.Point(269, 204);
            this.DeadLineEdit.MaximumSize = new System.Drawing.Size(200, 200);
            this.DeadLineEdit.Multiline = true;
            this.DeadLineEdit.Name = "DeadLineEdit";
            this.DeadLineEdit.Size = new System.Drawing.Size(200, 29);
            this.DeadLineEdit.TabIndex = 36;
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
            // SongEdit
            // 
            this.SongEdit.BackColor = System.Drawing.Color.White;
            this.SongEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SongEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SongEdit.ForeColor = System.Drawing.Color.Black;
            this.SongEdit.Location = new System.Drawing.Point(269, 280);
            this.SongEdit.MaximumSize = new System.Drawing.Size(200, 200);
            this.SongEdit.Multiline = true;
            this.SongEdit.Name = "SongEdit";
            this.SongEdit.Size = new System.Drawing.Size(200, 29);
            this.SongEdit.TabIndex = 31;
            // 
            // VideoNameEdit
            // 
            this.VideoNameEdit.BackColor = System.Drawing.Color.White;
            this.VideoNameEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VideoNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.VideoNameEdit.ForeColor = System.Drawing.Color.Black;
            this.VideoNameEdit.Location = new System.Drawing.Point(269, 132);
            this.VideoNameEdit.MaximumSize = new System.Drawing.Size(200, 200);
            this.VideoNameEdit.Multiline = true;
            this.VideoNameEdit.Name = "VideoNameEdit";
            this.VideoNameEdit.Size = new System.Drawing.Size(200, 29);
            this.VideoNameEdit.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(117, 264);
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
            this.label3.Location = new System.Drawing.Point(55, 188);
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
            this.label2.Location = new System.Drawing.Point(10, 116);
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
            this.lbltxt.Size = new System.Drawing.Size(282, 65);
            this.lbltxt.TabIndex = 13;
            this.lbltxt.Text = "Edit Videos";
            // 
            // EditVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 575);
            this.Controls.Add(this.gradientColor1);
            this.Name = "EditVideo";
            this.Text = "EditVideo";
            this.gradientColor1.ResumeLayout(false);
            this.gradientColor1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientColor gradientColor1;
        private Bunifu.UI.WinForms.BunifuCheckBox StatusEdit;
        private System.Windows.Forms.TextBox DeadLineEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox SongEdit;
        private System.Windows.Forms.TextBox VideoNameEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Label label1;
    }
}