namespace Sapphire_LITE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.WrongPass = new System.Windows.Forms.Label();
            this.Key = new Guna.UI2.WinForms.Guna2TextBox();
            this.Switch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.LoginButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.controlbar = new System.Windows.Forms.Panel();
            this.watermarkImage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dragBar = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1.SuspendLayout();
            this.controlbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermarkImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.WrongPass);
            this.panel1.Controls.Add(this.Key);
            this.panel1.Controls.Add(this.Switch);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.controlbar);
            this.panel1.Controls.Add(this.dragBar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 336);
            this.panel1.TabIndex = 1;
            // 
            // WrongPass
            // 
            this.WrongPass.AutoSize = true;
            this.WrongPass.ForeColor = System.Drawing.Color.Red;
            this.WrongPass.Location = new System.Drawing.Point(104, 193);
            this.WrongPass.Name = "WrongPass";
            this.WrongPass.Size = new System.Drawing.Size(141, 13);
            this.WrongPass.TabIndex = 10;
            this.WrongPass.Text = "Wrong Username/Password";
            this.WrongPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WrongPass.Visible = false;
            // 
            // Key
            // 
            this.Key.Animated = true;
            this.Key.AutoRoundedCorners = true;
            this.Key.BorderColor = System.Drawing.Color.Transparent;
            this.Key.BorderRadius = 17;
            this.Key.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Key.DefaultText = "";
            this.Key.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Key.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Key.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Key.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Key.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Key.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Key.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Key.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Key.Location = new System.Drawing.Point(107, 120);
            this.Key.Name = "Key";
            this.Key.PasswordChar = '\0';
            this.Key.PlaceholderText = "Key";
            this.Key.SelectedText = "";
            this.Key.Size = new System.Drawing.Size(200, 36);
            this.Key.TabIndex = 9;
            this.Key.Visible = false;
            // 
            // Switch
            // 
            this.Switch.Animated = true;
            this.Switch.AutoRoundedCorners = true;
            this.Switch.BorderRadius = 14;
            this.Switch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Switch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Switch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Switch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Switch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Switch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.Switch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(107)))), ((int)(((byte)(221)))));
            this.Switch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Switch.ForeColor = System.Drawing.Color.White;
            this.Switch.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.Switch.Location = new System.Drawing.Point(107, 288);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(200, 31);
            this.Switch.TabIndex = 8;
            this.Switch.Text = "Use HWID/Key";
            this.Switch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SwitchLoginType);
            // 
            // LoginButton
            // 
            this.LoginButton.Animated = true;
            this.LoginButton.AnimatedGIF = true;
            this.LoginButton.AutoRoundedCorners = true;
            this.LoginButton.BorderRadius = 21;
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.LoginButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(107)))), ((int)(((byte)(221)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.LoginButton.Location = new System.Drawing.Point(107, 209);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.PressedDepth = 88;
            this.LoginButton.Size = new System.Drawing.Size(200, 45);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginButton_MouseClick);
            // 
            // Password
            // 
            this.Password.Animated = true;
            this.Password.AutoRoundedCorners = true;
            this.Password.BorderColor = System.Drawing.Color.Transparent;
            this.Password.BorderRadius = 17;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.Location = new System.Drawing.Point(107, 148);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.PlaceholderText = "Password";
            this.Password.SelectedText = "";
            this.Password.Size = new System.Drawing.Size(200, 36);
            this.Password.TabIndex = 6;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Username
            // 
            this.Username.Animated = true;
            this.Username.AutoRoundedCorners = true;
            this.Username.BorderColor = System.Drawing.Color.Transparent;
            this.Username.BorderRadius = 17;
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.DefaultText = "";
            this.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username.Location = new System.Drawing.Point(107, 87);
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.PlaceholderText = "Username";
            this.Username.SelectedText = "";
            this.Username.Size = new System.Drawing.Size(200, 36);
            this.Username.TabIndex = 5;
            // 
            // controlbar
            // 
            this.controlbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlbar.Controls.Add(this.watermarkImage);
            this.controlbar.Controls.Add(this.pictureBox2);
            this.controlbar.Controls.Add(this.guna2ControlBox2);
            this.controlbar.Controls.Add(this.guna2ControlBox1);
            this.controlbar.Controls.Add(this.panel7);
            this.controlbar.Location = new System.Drawing.Point(0, 5);
            this.controlbar.Name = "controlbar";
            this.controlbar.Size = new System.Drawing.Size(461, 45);
            this.controlbar.TabIndex = 4;
            // 
            // watermarkImage
            // 
            this.watermarkImage.BackgroundImage = global::Sapphire_LITE.Properties.Resources.Watermark;
            this.watermarkImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.watermarkImage.Location = new System.Drawing.Point(32, 5);
            this.watermarkImage.Name = "watermarkImage";
            this.watermarkImage.Size = new System.Drawing.Size(139, 35);
            this.watermarkImage.TabIndex = 6;
            this.watermarkImage.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Sapphire_LITE.Properties.Resources.Logo_with_glow___backgdasdsround;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(2, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 35);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(338, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(47, 44);
            this.guna2ControlBox2.TabIndex = 8;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(386, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(47, 44);
            this.guna2ControlBox1.TabIndex = 7;
            this.guna2ControlBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Exit);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel7.Location = new System.Drawing.Point(0, 44);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(461, 52);
            this.panel7.TabIndex = 5;
            // 
            // dragBar
            // 
            this.dragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.dragBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.dragBar.Location = new System.Drawing.Point(-3, 0);
            this.dragBar.Name = "dragBar";
            this.dragBar.Size = new System.Drawing.Size(464, 5);
            this.dragBar.TabIndex = 1;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.controlbar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.Interval = 280;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.panel1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2AnimateWindow2
            // 
            this.guna2AnimateWindow2.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_POSITIVE;
            this.guna2AnimateWindow2.TargetForm = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 331);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.controlbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.watermarkImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton LoginButton;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2TextBox Username;
        private System.Windows.Forms.Panel controlbar;
        private System.Windows.Forms.PictureBox watermarkImage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel dragBar;
        private Guna.UI2.WinForms.Guna2GradientButton Switch;
        private Guna.UI2.WinForms.Guna2TextBox Key;
        private System.Windows.Forms.Label WrongPass;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
    }
}