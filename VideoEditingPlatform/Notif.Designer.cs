
namespace VideoEditingPlatform
{
    partial class Notif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notif));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OnClickLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Delay = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Submit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.gradientColor1 = new VideoEditingPlatform.GradientColor();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gradientColor1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.OnClickLogout);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 636);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(20, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Technicien";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(4)))), ((int)(((byte)(110)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(27, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 58);
            this.button4.TabIndex = 8;
            this.button4.Text = "Notif";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(4)))), ((int)(((byte)(110)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(27, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 58);
            this.button3.TabIndex = 7;
            this.button3.Text = "Videos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(4)))), ((int)(((byte)(110)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(27, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clients";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OnClickLogout
            // 
            this.OnClickLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(4)))), ((int)(((byte)(110)))));
            this.OnClickLogout.BackgroundImage = global::VideoEditingPlatform.Properties.Resources.shutdown_128px;
            this.OnClickLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OnClickLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.OnClickLogout.ForeColor = System.Drawing.Color.White;
            this.OnClickLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OnClickLogout.Location = new System.Drawing.Point(74, 532);
            this.OnClickLogout.Name = "OnClickLogout";
            this.OnClickLogout.Size = new System.Drawing.Size(66, 59);
            this.OnClickLogout.TabIndex = 5;
            this.OnClickLogout.UseVisualStyleBackColor = false;
            this.OnClickLogout.Click += new System.EventHandler(this.OnClickLogout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(4)))), ((int)(((byte)(110)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(27, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delay
            // 
            this.Delay.AcceptsReturn = false;
            this.Delay.AcceptsTab = false;
            this.Delay.AnimationSpeed = 200;
            this.Delay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Delay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Delay.BackColor = System.Drawing.Color.Transparent;
            this.Delay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delay.BackgroundImage")));
            this.Delay.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Delay.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Delay.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Delay.BorderColorIdle = System.Drawing.Color.Silver;
            this.Delay.BorderRadius = 1;
            this.Delay.BorderThickness = 1;
            this.Delay.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Delay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Delay.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delay.DefaultText = "";
            this.Delay.FillColor = System.Drawing.Color.White;
            this.Delay.HideSelection = true;
            this.Delay.IconLeft = null;
            this.Delay.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Delay.IconPadding = 10;
            this.Delay.IconRight = null;
            this.Delay.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Delay.Lines = new string[0];
            this.Delay.Location = new System.Drawing.Point(574, 244);
            this.Delay.MaxLength = 32767;
            this.Delay.MinimumSize = new System.Drawing.Size(1, 1);
            this.Delay.Modified = false;
            this.Delay.Multiline = false;
            this.Delay.Name = "Delay";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Delay.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Delay.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Delay.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Delay.OnIdleState = stateProperties12;
            this.Delay.Padding = new System.Windows.Forms.Padding(3);
            this.Delay.PasswordChar = '\0';
            this.Delay.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Delay.PlaceholderText = "Enter a Number";
            this.Delay.ReadOnly = false;
            this.Delay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Delay.SelectedText = "";
            this.Delay.SelectionLength = 0;
            this.Delay.SelectionStart = 0;
            this.Delay.ShortcutsEnabled = true;
            this.Delay.Size = new System.Drawing.Size(260, 52);
            this.Delay.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Delay.TabIndex = 3;
            this.Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Delay.TextMarginBottom = 0;
            this.Delay.TextMarginLeft = 3;
            this.Delay.TextMarginTop = 0;
            this.Delay.TextPlaceholder = "Enter a Number";
            this.Delay.UseSystemPasswordChar = false;
            this.Delay.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(642, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Delay :";
            // 
            // Submit
            // 
            this.Submit.AllowAnimations = true;
            this.Submit.AllowMouseEffects = true;
            this.Submit.AllowToggling = false;
            this.Submit.AnimationSpeed = 200;
            this.Submit.AutoGenerateColors = false;
            this.Submit.AutoRoundBorders = false;
            this.Submit.AutoSizeLeftIcon = true;
            this.Submit.AutoSizeRightIcon = true;
            this.Submit.BackColor = System.Drawing.Color.Transparent;
            this.Submit.BackColor1 = System.Drawing.Color.Lime;
            this.Submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Submit.BackgroundImage")));
            this.Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Submit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Submit.ButtonText = "Submit";
            this.Submit.ButtonTextMarginLeft = 0;
            this.Submit.ColorContrastOnClick = 45;
            this.Submit.ColorContrastOnHover = 45;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.Submit.CustomizableEdges = borderEdges3;
            this.Submit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Submit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Submit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Submit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Submit.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Submit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Submit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Submit.IconMarginLeft = 11;
            this.Submit.IconPadding = 10;
            this.Submit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Submit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Submit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Submit.IconSize = 25;
            this.Submit.IdleBorderColor = System.Drawing.Color.Lime;
            this.Submit.IdleBorderRadius = 1;
            this.Submit.IdleBorderThickness = 1;
            this.Submit.IdleFillColor = System.Drawing.Color.Lime;
            this.Submit.IdleIconLeftImage = null;
            this.Submit.IdleIconRightImage = null;
            this.Submit.IndicateFocus = false;
            this.Submit.Location = new System.Drawing.Point(629, 326);
            this.Submit.Name = "Submit";
            this.Submit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Submit.OnDisabledState.BorderRadius = 1;
            this.Submit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Submit.OnDisabledState.BorderThickness = 1;
            this.Submit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Submit.OnDisabledState.IconLeftImage = null;
            this.Submit.OnDisabledState.IconRightImage = null;
            this.Submit.onHoverState.BorderColor = System.Drawing.Color.Lime;
            this.Submit.onHoverState.BorderRadius = 1;
            this.Submit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Submit.onHoverState.BorderThickness = 1;
            this.Submit.onHoverState.FillColor = System.Drawing.Color.Lime;
            this.Submit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Submit.onHoverState.IconLeftImage = null;
            this.Submit.onHoverState.IconRightImage = null;
            this.Submit.OnIdleState.BorderColor = System.Drawing.Color.Lime;
            this.Submit.OnIdleState.BorderRadius = 1;
            this.Submit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Submit.OnIdleState.BorderThickness = 1;
            this.Submit.OnIdleState.FillColor = System.Drawing.Color.Lime;
            this.Submit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Submit.OnIdleState.IconLeftImage = null;
            this.Submit.OnIdleState.IconRightImage = null;
            this.Submit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Submit.OnPressedState.BorderRadius = 1;
            this.Submit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Submit.OnPressedState.BorderThickness = 1;
            this.Submit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Submit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Submit.OnPressedState.IconLeftImage = null;
            this.Submit.OnPressedState.IconRightImage = null;
            this.Submit.Size = new System.Drawing.Size(150, 39);
            this.Submit.TabIndex = 13;
            this.Submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Submit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Submit.TextMarginLeft = 0;
            this.Submit.TextPadding = new System.Windows.Forms.Padding(0);
            this.Submit.UseDefaultRadiusAndThickness = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // gradientColor1
            // 
            this.gradientColor1.Angle = 0F;
            this.gradientColor1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gradientColor1.Controls.Add(this.label3);
            this.gradientColor1.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.gradientColor1.Location = new System.Drawing.Point(2, 1);
            this.gradientColor1.Name = "gradientColor1";
            this.gradientColor1.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gradientColor1.Size = new System.Drawing.Size(1637, 79);
            this.gradientColor1.TabIndex = 14;
            this.gradientColor1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.gradientColor1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientColor1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(394, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 50);
            this.label3.TabIndex = 12;
            this.label3.Text = "Notification Settings";
            // 
            // Notif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 618);
            this.Controls.Add(this.gradientColor1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.panel1);
            this.Name = "Notif";
            this.Text = "Notif";
            this.Load += new System.EventHandler(this.Notif_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gradientColor1.ResumeLayout(false);
            this.gradientColor1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OnClickLogout;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuTextBox Delay;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Submit;
        private GradientColor gradientColor1;
        private System.Windows.Forms.Label label3;
    }
}