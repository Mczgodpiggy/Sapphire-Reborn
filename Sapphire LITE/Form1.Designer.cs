namespace Sapphire_LITE {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FadeInTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Repair = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ConfigPanel = new System.Windows.Forms.Panel();
            this.configStatus = new System.Windows.Forms.Label();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.configList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AddAConfig = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ConfigName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.RACCheck = new System.Windows.Forms.CheckBox();
            this.LACCheck = new System.Windows.Forms.CheckBox();
            this.rightMaxCpsText = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.leftMaxCpsText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rightMaxCpsSlider = new FlatUI.FlatTrackBar();
            this.leftMaxCpsSlider = new FlatUI.FlatTrackBar();
            this.leftMinCpsSlider = new FlatUI.FlatTrackBar();
            this.rightClickerBindButton = new System.Windows.Forms.Label();
            this.leftClickerBindButton = new System.Windows.Forms.Label();
            this.presetSelector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.toggleSmartMode = new Guna.UI2.WinForms.Guna2CheckBox();
            this.randomizationText = new System.Windows.Forms.Label();
            this.toggleAlwaysOn = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.randomizationSlider = new FlatUI.FlatTrackBar();
            this.toggleShiftDisable = new Guna.UI2.WinForms.Guna2CheckBox();
            this.rightMinCpsText = new System.Windows.Forms.Label();
            this.toggleRandomization = new Guna.UI2.WinForms.Guna2CheckBox();
            this.rightMinCpsSlider = new FlatUI.FlatTrackBar();
            this.leftMinCpsText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.controlbar = new System.Windows.Forms.Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.watermarkImage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LoadedConfigText = new System.Windows.Forms.Label();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.Shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PanelTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ConfigPanel.SuspendLayout();
            this.controlbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermarkImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // FadeInTimer
            // 
            this.FadeInTimer.Enabled = true;
            this.FadeInTimer.Interval = 68;
            this.FadeInTimer.Tick += new System.EventHandler(this.FadeInTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.Repair);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.controlbar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.LoadedConfigText);
            this.PanelTransition.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 336);
            this.panel1.TabIndex = 0;
            // 
            // Repair
            // 
            this.Repair.Animated = true;
            this.Repair.AutoRoundedCorners = true;
            this.Repair.BackColor = System.Drawing.Color.Transparent;
            this.Repair.BorderRadius = 10;
            this.PanelTransition.SetDecoration(this.Repair, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Repair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Repair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Repair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Repair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Repair.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.Repair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Repair.ForeColor = System.Drawing.Color.White;
            this.Repair.Image = ((System.Drawing.Image)(resources.GetObject("Repair.Image")));
            this.Repair.Location = new System.Drawing.Point(0, 314);
            this.Repair.Name = "Repair";
            this.Repair.Size = new System.Drawing.Size(45, 22);
            this.Repair.TabIndex = 30;
            this.ToolTip.SetToolTip(this.Repair, "Repairs the client if you\'ve done something retarded");
            this.Repair.MouseClick += new System.Windows.Forms.MouseEventHandler(this.repair);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel4.Controls.Add(this.ConfigPanel);
            this.panel4.Controls.Add(this.guna2GradientCircleButton2);
            this.panel4.Controls.Add(this.RACCheck);
            this.panel4.Controls.Add(this.LACCheck);
            this.panel4.Controls.Add(this.rightMaxCpsText);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.leftMaxCpsText);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.rightMaxCpsSlider);
            this.panel4.Controls.Add(this.leftMaxCpsSlider);
            this.panel4.Controls.Add(this.leftMinCpsSlider);
            this.panel4.Controls.Add(this.rightClickerBindButton);
            this.panel4.Controls.Add(this.leftClickerBindButton);
            this.panel4.Controls.Add(this.presetSelector);
            this.panel4.Controls.Add(this.toggleSmartMode);
            this.panel4.Controls.Add(this.randomizationText);
            this.panel4.Controls.Add(this.toggleAlwaysOn);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.randomizationSlider);
            this.panel4.Controls.Add(this.toggleShiftDisable);
            this.panel4.Controls.Add(this.rightMinCpsText);
            this.panel4.Controls.Add(this.toggleRandomization);
            this.panel4.Controls.Add(this.rightMinCpsSlider);
            this.panel4.Controls.Add(this.leftMinCpsText);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel5);
            this.PanelTransition.SetDecoration(this.panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(14, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(407, 260);
            this.panel4.TabIndex = 4;
            // 
            // ConfigPanel
            // 
            this.ConfigPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ConfigPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ConfigPanel.Controls.Add(this.configStatus);
            this.ConfigPanel.Controls.Add(this.guna2CircleButton2);
            this.ConfigPanel.Controls.Add(this.configList);
            this.ConfigPanel.Controls.Add(this.AddAConfig);
            this.ConfigPanel.Controls.Add(this.guna2CircleButton1);
            this.ConfigPanel.Controls.Add(this.ConfigName);
            this.ConfigPanel.Controls.Add(this.guna2GradientCircleButton1);
            this.ConfigPanel.Controls.Add(this.label2);
            this.ConfigPanel.Controls.Add(this.panel6);
            this.PanelTransition.SetDecoration(this.ConfigPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ConfigPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ConfigPanel.Location = new System.Drawing.Point(42, 11);
            this.ConfigPanel.Name = "ConfigPanel";
            this.ConfigPanel.Size = new System.Drawing.Size(322, 237);
            this.ConfigPanel.TabIndex = 28;
            this.ConfigPanel.Visible = false;
            // 
            // configStatus
            // 
            this.PanelTransition.SetDecoration(this.configStatus, Guna.UI2.AnimatorNS.DecorationType.None);
            this.configStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configStatus.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configStatus.ForeColor = System.Drawing.Color.Red;
            this.configStatus.Location = new System.Drawing.Point(41, 148);
            this.configStatus.Name = "configStatus";
            this.configStatus.Size = new System.Drawing.Size(250, 18);
            this.configStatus.TabIndex = 31;
            this.configStatus.Text = "Config doesn\'t exist";
            this.configStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.configStatus.Visible = false;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.Animated = true;
            this.PanelTransition.SetDecoration(this.guna2CircleButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton2.Image")));
            this.guna2CircleButton2.Location = new System.Drawing.Point(143, 184);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(38, 38);
            this.guna2CircleButton2.TabIndex = 30;
            this.ToolTip.SetToolTip(this.guna2CircleButton2, "Delete a config");
            this.guna2CircleButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.holdDown);
            this.guna2CircleButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.holdUp);
            // 
            // configList
            // 
            this.configList.Animated = true;
            this.configList.AutoRoundedCorners = true;
            this.configList.BackColor = System.Drawing.Color.Transparent;
            this.configList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.configList.BorderRadius = 17;
            this.PanelTransition.SetDecoration(this.configList, Guna.UI2.AnimatorNS.DecorationType.None);
            this.configList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.configList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.configList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.configList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.configList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.configList.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.configList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.configList.FormattingEnabled = true;
            this.configList.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.configList.ItemHeight = 30;
            this.configList.Location = new System.Drawing.Point(65, 104);
            this.configList.Name = "configList";
            this.configList.Size = new System.Drawing.Size(201, 36);
            this.configList.TabIndex = 29;
            this.ToolTip.SetToolTip(this.configList, "Lists of created configs");
            this.configList.DropDown += new System.EventHandler(this.configListClick);
            this.configList.SelectedIndexChanged += new System.EventHandler(this.configList_SelectedIndexChanged);
            this.configList.DropDownClosed += new System.EventHandler(this.configListClick);
            // 
            // AddAConfig
            // 
            this.AddAConfig.Animated = true;
            this.PanelTransition.SetDecoration(this.AddAConfig, Guna.UI2.AnimatorNS.DecorationType.None);
            this.AddAConfig.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddAConfig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddAConfig.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddAConfig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddAConfig.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.AddAConfig.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.AddAConfig.ForeColor = System.Drawing.Color.Black;
            this.AddAConfig.Location = new System.Drawing.Point(281, 184);
            this.AddAConfig.Name = "AddAConfig";
            this.AddAConfig.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.AddAConfig.Size = new System.Drawing.Size(38, 38);
            this.AddAConfig.TabIndex = 10;
            this.AddAConfig.Text = "+";
            this.AddAConfig.TextOffset = new System.Drawing.Point(2, -4);
            this.ToolTip.SetToolTip(this.AddAConfig, "Create a config");
            this.AddAConfig.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddConfig);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Animated = true;
            this.PanelTransition.SetDecoration(this.guna2CircleButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.Location = new System.Drawing.Point(3, 184);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(38, 38);
            this.guna2CircleButton1.TabIndex = 9;
            this.ToolTip.SetToolTip(this.guna2CircleButton1, "Import a config");
            this.guna2CircleButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImportConfig);
            // 
            // ConfigName
            // 
            this.ConfigName.Animated = true;
            this.ConfigName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(116)))), ((int)(((byte)(226)))));
            this.ConfigName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PanelTransition.SetDecoration(this.ConfigName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ConfigName.DefaultText = "";
            this.ConfigName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfigName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfigName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfigName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfigName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ConfigName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfigName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.ConfigName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfigName.Location = new System.Drawing.Point(66, 53);
            this.ConfigName.Name = "ConfigName";
            this.ConfigName.PasswordChar = '\0';
            this.ConfigName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ConfigName.PlaceholderText = "Config Name";
            this.ConfigName.SelectedText = "";
            this.ConfigName.Size = new System.Drawing.Size(200, 36);
            this.ConfigName.TabIndex = 8;
            // 
            // guna2GradientCircleButton1
            // 
            this.guna2GradientCircleButton1.Animated = true;
            this.guna2GradientCircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.guna2GradientCircleButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.guna2GradientCircleButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientCircleButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientCircleButton1.IndicateFocus = true;
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(283, 9);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(88)))), ((int)(((byte)(218)))));
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(36, 36);
            this.guna2GradientCircleButton1.TabIndex = 7;
            this.guna2GradientCircleButton1.Text = "x";
            this.guna2GradientCircleButton1.TextOffset = new System.Drawing.Point(1, -3);
            this.ToolTip.SetToolTip(this.guna2GradientCircleButton1, "Close this window");
            this.guna2GradientCircleButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseConfigWindow);
            // 
            // label2
            // 
            this.PanelTransition.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(62, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Or Load A Config";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.PanelTransition.SetDecoration(this.panel6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel6.Location = new System.Drawing.Point(-139, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(558, 5);
            this.panel6.TabIndex = 2;
            // 
            // guna2GradientCircleButton2
            // 
            this.guna2GradientCircleButton2.Animated = true;
            this.guna2GradientCircleButton2.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.guna2GradientCircleButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientCircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.guna2GradientCircleButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.guna2GradientCircleButton2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientCircleButton2.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientCircleButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientCircleButton2.IndicateFocus = true;
            this.guna2GradientCircleButton2.Location = new System.Drawing.Point(372, 219);
            this.guna2GradientCircleButton2.Name = "guna2GradientCircleButton2";
            this.guna2GradientCircleButton2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(88)))), ((int)(((byte)(218)))));
            this.guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton2.Size = new System.Drawing.Size(33, 33);
            this.guna2GradientCircleButton2.TabIndex = 9;
            this.guna2GradientCircleButton2.Text = "+";
            this.guna2GradientCircleButton2.TextOffset = new System.Drawing.Point(1, -1);
            this.ToolTip.SetToolTip(this.guna2GradientCircleButton2, "Create this config");
            this.guna2GradientCircleButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OpenConfigWindow);
            // 
            // RACCheck
            // 
            this.PanelTransition.SetDecoration(this.RACCheck, Guna.UI2.AnimatorNS.DecorationType.None);
            this.RACCheck.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RACCheck.ForeColor = System.Drawing.Color.Transparent;
            this.RACCheck.Location = new System.Drawing.Point(4, 111);
            this.RACCheck.Name = "RACCheck";
            this.RACCheck.Size = new System.Drawing.Size(109, 23);
            this.RACCheck.TabIndex = 27;
            this.RACCheck.Text = "Right Clicker";
            this.RACCheck.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ToggleRAC);
            // 
            // LACCheck
            // 
            this.PanelTransition.SetDecoration(this.LACCheck, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LACCheck.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LACCheck.ForeColor = System.Drawing.Color.Transparent;
            this.LACCheck.Location = new System.Drawing.Point(4, 42);
            this.LACCheck.Name = "LACCheck";
            this.LACCheck.Size = new System.Drawing.Size(101, 23);
            this.LACCheck.TabIndex = 26;
            this.LACCheck.Text = "Left Clicker";
            this.LACCheck.UseVisualStyleBackColor = true;
            this.LACCheck.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ToggleLAC);
            // 
            // rightMaxCpsText
            // 
            this.PanelTransition.SetDecoration(this.rightMaxCpsText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.rightMaxCpsText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightMaxCpsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rightMaxCpsText.Location = new System.Drawing.Point(363, 178);
            this.rightMaxCpsText.Name = "rightMaxCpsText";
            this.rightMaxCpsText.Size = new System.Drawing.Size(32, 17);
            this.rightMaxCpsText.TabIndex = 23;
            this.rightMaxCpsText.Text = "12.5";
            this.rightMaxCpsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label9.Location = new System.Drawing.Point(370, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "MAX";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // leftMaxCpsText
            // 
            this.PanelTransition.SetDecoration(this.leftMaxCpsText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.leftMaxCpsText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftMaxCpsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.leftMaxCpsText.Location = new System.Drawing.Point(363, 111);
            this.leftMaxCpsText.Name = "leftMaxCpsText";
            this.leftMaxCpsText.Size = new System.Drawing.Size(35, 17);
            this.leftMaxCpsText.TabIndex = 21;
            this.leftMaxCpsText.Text = "12.5";
            this.leftMaxCpsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label6.Location = new System.Drawing.Point(370, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "MAX";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label4.Location = new System.Drawing.Point(370, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "MIN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label3.Location = new System.Drawing.Point(370, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "MIN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rightMaxCpsSlider
            // 
            this.rightMaxCpsSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.rightMaxCpsSlider.ColorScheme1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.rightMaxCpsSlider.ColorScheme2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.rightMaxCpsSlider.Decimal = false;
            this.PanelTransition.SetDecoration(this.rightMaxCpsSlider, Guna.UI2.AnimatorNS.DecorationType.None);
            this.rightMaxCpsSlider.FloatValue = 0D;
            this.rightMaxCpsSlider.Full = false;
            this.rightMaxCpsSlider.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.rightMaxCpsSlider.Location = new System.Drawing.Point(14, 161);
            this.rightMaxCpsSlider.Maximum = 300;
            this.rightMaxCpsSlider.Minimum = 50;
            this.rightMaxCpsSlider.Name = "rightMaxCpsSlider";
            this.rightMaxCpsSlider.ShowValue = false;
            this.rightMaxCpsSlider.Size = new System.Drawing.Size(355, 12);
            this.rightMaxCpsSlider.TabIndex = 17;
            this.rightMaxCpsSlider.Text = "RMax";
            this.ToolTip.SetToolTip(this.rightMaxCpsSlider, "Average amount of right clicks that will be sent to the game");
            this.rightMaxCpsSlider.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.rightMaxCpsSlider.Value = 125;
            this.rightMaxCpsSlider.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.rightMaxCpsSlider_Scroll);
            // 
            // leftMaxCpsSlider
            // 
            this.leftMaxCpsSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.leftMaxCpsSlider.ColorScheme1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.leftMaxCpsSlider.ColorScheme2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.leftMaxCpsSlider.Decimal = false;
            this.PanelTransition.SetDecoration(this.leftMaxCpsSlider, Guna.UI2.AnimatorNS.DecorationType.None);
            this.leftMaxCpsSlider.FloatValue = 0D;
            this.leftMaxCpsSlider.Full = false;
            this.leftMaxCpsSlider.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.leftMaxCpsSlider.Location = new System.Drawing.Point(14, 97);
            this.leftMaxCpsSlider.Maximum = 300;
            this.leftMaxCpsSlider.Minimum = 50;
            this.leftMaxCpsSlider.Name = "leftMaxCpsSlider";
            this.leftMaxCpsSlider.ShowValue = false;
            this.leftMaxCpsSlider.Size = new System.Drawing.Size(355, 12);
            this.leftMaxCpsSlider.TabIndex = 16;
            this.leftMaxCpsSlider.Text = "LMax";
            this.ToolTip.SetToolTip(this.leftMaxCpsSlider, "Average amount of left clicks that will be sent to the game");
            this.leftMaxCpsSlider.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.leftMaxCpsSlider.Value = 125;
            this.leftMaxCpsSlider.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.leftMaxCpsSlider_Scroll);
            // 
            // leftMinCpsSlider
            // 
            this.leftMinCpsSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.leftMinCpsSlider.ColorScheme1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.leftMinCpsSlider.ColorScheme2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.leftMinCpsSlider.Decimal = false;
            this.PanelTransition.SetDecoration(this.leftMinCpsSlider, Guna.UI2.AnimatorNS.DecorationType.None);
            this.leftMinCpsSlider.FloatValue = 0D;
            this.leftMinCpsSlider.Full = false;
            this.leftMinCpsSlider.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.leftMinCpsSlider.Location = new System.Drawing.Point(16, 64);
            this.leftMinCpsSlider.Maximum = 300;
            this.leftMinCpsSlider.Minimum = 50;
            this.leftMinCpsSlider.Name = "leftMinCpsSlider";
            this.leftMinCpsSlider.ShowValue = false;
            this.leftMinCpsSlider.Size = new System.Drawing.Size(355, 12);
            this.leftMinCpsSlider.TabIndex = 2;
            this.leftMinCpsSlider.Text = "LMin";
            this.ToolTip.SetToolTip(this.leftMinCpsSlider, "Average amount of left clicks that will be sent to the game");
            this.leftMinCpsSlider.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.leftMinCpsSlider.Value = 125;
            this.leftMinCpsSlider.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.leftMinCpsSlider_Scroll);
            // 
            // rightClickerBindButton
            // 
            this.PanelTransition.SetDecoration(this.rightClickerBindButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.rightClickerBindButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightClickerBindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.rightClickerBindButton.Location = new System.Drawing.Point(135, 110);
            this.rightClickerBindButton.Name = "rightClickerBindButton";
            this.rightClickerBindButton.Size = new System.Drawing.Size(134, 17);
            this.rightClickerBindButton.TabIndex = 15;
            this.rightClickerBindButton.Text = "[none]";
            this.rightClickerBindButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rightClickerBindButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightClickerBindButton_MouseDown);
            // 
            // leftClickerBindButton
            // 
            this.PanelTransition.SetDecoration(this.leftClickerBindButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.leftClickerBindButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftClickerBindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.leftClickerBindButton.Location = new System.Drawing.Point(135, 45);
            this.leftClickerBindButton.Name = "leftClickerBindButton";
            this.leftClickerBindButton.Size = new System.Drawing.Size(134, 17);
            this.leftClickerBindButton.TabIndex = 14;
            this.leftClickerBindButton.Text = "[none]";
            this.leftClickerBindButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leftClickerBindButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.leftClickerBindButton_MouseDown);
            // 
            // presetSelector
            // 
            this.presetSelector.Animated = true;
            this.presetSelector.AutoRoundedCorners = true;
            this.presetSelector.BackColor = System.Drawing.Color.Transparent;
            this.presetSelector.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.presetSelector.BorderRadius = 17;
            this.PanelTransition.SetDecoration(this.presetSelector, Guna.UI2.AnimatorNS.DecorationType.None);
            this.presetSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.presetSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetSelector.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.presetSelector.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.presetSelector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.presetSelector.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetSelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.presetSelector.FormattingEnabled = true;
            this.presetSelector.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.presetSelector.ItemHeight = 30;
            this.presetSelector.Items.AddRange(new object[] {
            "Default",
            "Low CPS",
            "High CPS"});
            this.presetSelector.Location = new System.Drawing.Point(228, 216);
            this.presetSelector.Name = "presetSelector";
            this.presetSelector.Size = new System.Drawing.Size(141, 36);
            this.presetSelector.StartIndex = 0;
            this.presetSelector.TabIndex = 13;
            this.ToolTip.SetToolTip(this.presetSelector, "Allows you to set a preset depending on what cps you want.");
            this.presetSelector.DropDown += new System.EventHandler(this.presetSelectorClick);
            this.presetSelector.SelectedIndexChanged += new System.EventHandler(this.presetSelector_SelectedIndexChanged);
            this.presetSelector.DropDownClosed += new System.EventHandler(this.presetSelectorClick);
            // 
            // toggleSmartMode
            // 
            this.toggleSmartMode.Animated = true;
            this.toggleSmartMode.AutoSize = true;
            this.toggleSmartMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.toggleSmartMode.CheckedState.BorderRadius = 1;
            this.toggleSmartMode.CheckedState.BorderThickness = 0;
            this.toggleSmartMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.PanelTransition.SetDecoration(this.toggleSmartMode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.toggleSmartMode.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSmartMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.toggleSmartMode.Location = new System.Drawing.Point(127, 237);
            this.toggleSmartMode.Name = "toggleSmartMode";
            this.toggleSmartMode.Size = new System.Drawing.Size(96, 18);
            this.toggleSmartMode.TabIndex = 8;
            this.toggleSmartMode.Text = "smart mode";
            this.ToolTip.SetToolTip(this.toggleSmartMode, resources.GetString("toggleSmartMode.ToolTip"));
            this.toggleSmartMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleSmartMode.UncheckedState.BorderRadius = 1;
            this.toggleSmartMode.UncheckedState.BorderThickness = 0;
            this.toggleSmartMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleSmartMode.UseVisualStyleBackColor = true;
            this.toggleSmartMode.CheckedChanged += new System.EventHandler(this.toggleSmartMode_CheckedChanged);
            // 
            // randomizationText
            // 
            this.PanelTransition.SetDecoration(this.randomizationText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.randomizationText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomizationText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.randomizationText.Location = new System.Drawing.Point(349, 195);
            this.randomizationText.Name = "randomizationText";
            this.randomizationText.Size = new System.Drawing.Size(45, 17);
            this.randomizationText.TabIndex = 12;
            this.randomizationText.Text = "25%";
            this.randomizationText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toggleAlwaysOn
            // 
            this.toggleAlwaysOn.Animated = true;
            this.toggleAlwaysOn.AutoSize = true;
            this.toggleAlwaysOn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.toggleAlwaysOn.CheckedState.BorderRadius = 1;
            this.toggleAlwaysOn.CheckedState.BorderThickness = 0;
            this.toggleAlwaysOn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.PanelTransition.SetDecoration(this.toggleAlwaysOn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.toggleAlwaysOn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleAlwaysOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.toggleAlwaysOn.Location = new System.Drawing.Point(127, 216);
            this.toggleAlwaysOn.Name = "toggleAlwaysOn";
            this.toggleAlwaysOn.Size = new System.Drawing.Size(89, 18);
            this.toggleAlwaysOn.TabIndex = 7;
            this.toggleAlwaysOn.Text = "always on";
            this.ToolTip.SetToolTip(this.toggleAlwaysOn, "Allows left or right clicker to click automatically when they\'re enabled.");
            this.toggleAlwaysOn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleAlwaysOn.UncheckedState.BorderRadius = 1;
            this.toggleAlwaysOn.UncheckedState.BorderThickness = 0;
            this.toggleAlwaysOn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleAlwaysOn.UseVisualStyleBackColor = true;
            this.toggleAlwaysOn.CheckedChanged += new System.EventHandler(this.toggleAlwaysOn_CheckedChanged);
            // 
            // label7
            // 
            this.PanelTransition.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "randomization distribution";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.label7, "The slight MS adjustment applied to the existing randomized cps.");
            // 
            // randomizationSlider
            // 
            this.randomizationSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.randomizationSlider.ColorScheme1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.randomizationSlider.ColorScheme2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.randomizationSlider.Decimal = false;
            this.PanelTransition.SetDecoration(this.randomizationSlider, Guna.UI2.AnimatorNS.DecorationType.None);
            this.randomizationSlider.FloatValue = 0D;
            this.randomizationSlider.Full = false;
            this.randomizationSlider.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.randomizationSlider.Location = new System.Drawing.Point(13, 198);
            this.randomizationSlider.Maximum = 100;
            this.randomizationSlider.Minimum = 1;
            this.randomizationSlider.Name = "randomizationSlider";
            this.randomizationSlider.ShowValue = false;
            this.randomizationSlider.Size = new System.Drawing.Size(355, 12);
            this.randomizationSlider.TabIndex = 10;
            this.randomizationSlider.Text = "flatTrackBar3";
            this.ToolTip.SetToolTip(this.randomizationSlider, "The amount of deviation the randomization is allowed to have from its intended cp" +
        "s");
            this.randomizationSlider.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.randomizationSlider.Value = 25;
            this.randomizationSlider.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.jitterSlider_Scroll);
            // 
            // toggleShiftDisable
            // 
            this.toggleShiftDisable.Animated = true;
            this.toggleShiftDisable.AutoSize = true;
            this.toggleShiftDisable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.toggleShiftDisable.CheckedState.BorderRadius = 1;
            this.toggleShiftDisable.CheckedState.BorderThickness = 0;
            this.toggleShiftDisable.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.PanelTransition.SetDecoration(this.toggleShiftDisable, Guna.UI2.AnimatorNS.DecorationType.None);
            this.toggleShiftDisable.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleShiftDisable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.toggleShiftDisable.Location = new System.Drawing.Point(16, 237);
            this.toggleShiftDisable.Name = "toggleShiftDisable";
            this.toggleShiftDisable.Size = new System.Drawing.Size(117, 18);
            this.toggleShiftDisable.TabIndex = 6;
            this.toggleShiftDisable.Text = "shift disable";
            this.ToolTip.SetToolTip(this.toggleShiftDisable, "Disables all function when the \"Shift\" key is held.");
            this.toggleShiftDisable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleShiftDisable.UncheckedState.BorderRadius = 1;
            this.toggleShiftDisable.UncheckedState.BorderThickness = 0;
            this.toggleShiftDisable.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleShiftDisable.UseVisualStyleBackColor = true;
            this.toggleShiftDisable.CheckedChanged += new System.EventHandler(this.toggleShiftDisable_CheckedChanged);
            // 
            // rightMinCpsText
            // 
            this.PanelTransition.SetDecoration(this.rightMinCpsText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.rightMinCpsText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightMinCpsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rightMinCpsText.Location = new System.Drawing.Point(363, 144);
            this.rightMinCpsText.Name = "rightMinCpsText";
            this.rightMinCpsText.Size = new System.Drawing.Size(32, 17);
            this.rightMinCpsText.TabIndex = 9;
            this.rightMinCpsText.Text = "12.5";
            this.rightMinCpsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toggleRandomization
            // 
            this.toggleRandomization.Animated = true;
            this.toggleRandomization.AutoSize = true;
            this.toggleRandomization.Checked = true;
            this.toggleRandomization.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.toggleRandomization.CheckedState.BorderRadius = 1;
            this.toggleRandomization.CheckedState.BorderThickness = 0;
            this.toggleRandomization.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.toggleRandomization.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PanelTransition.SetDecoration(this.toggleRandomization, Guna.UI2.AnimatorNS.DecorationType.None);
            this.toggleRandomization.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleRandomization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.toggleRandomization.Location = new System.Drawing.Point(16, 216);
            this.toggleRandomization.Name = "toggleRandomization";
            this.toggleRandomization.Size = new System.Drawing.Size(117, 18);
            this.toggleRandomization.TabIndex = 5;
            this.toggleRandomization.Text = "randomization";
            this.ToolTip.SetToolTip(this.toggleRandomization, "Create a more \"humanized\" randomization to lower the chances of getting detected." +
        "");
            this.toggleRandomization.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleRandomization.UncheckedState.BorderRadius = 1;
            this.toggleRandomization.UncheckedState.BorderThickness = 0;
            this.toggleRandomization.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleRandomization.UseVisualStyleBackColor = true;
            this.toggleRandomization.CheckedChanged += new System.EventHandler(this.toggleRandomization_CheckedChanged);
            // 
            // rightMinCpsSlider
            // 
            this.rightMinCpsSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.rightMinCpsSlider.ColorScheme1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.rightMinCpsSlider.ColorScheme2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.rightMinCpsSlider.Decimal = false;
            this.PanelTransition.SetDecoration(this.rightMinCpsSlider, Guna.UI2.AnimatorNS.DecorationType.None);
            this.rightMinCpsSlider.FloatValue = 0D;
            this.rightMinCpsSlider.Full = false;
            this.rightMinCpsSlider.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.rightMinCpsSlider.Location = new System.Drawing.Point(14, 132);
            this.rightMinCpsSlider.Maximum = 300;
            this.rightMinCpsSlider.Minimum = 50;
            this.rightMinCpsSlider.Name = "rightMinCpsSlider";
            this.rightMinCpsSlider.ShowValue = false;
            this.rightMinCpsSlider.Size = new System.Drawing.Size(355, 12);
            this.rightMinCpsSlider.TabIndex = 7;
            this.rightMinCpsSlider.Text = "RMin";
            this.ToolTip.SetToolTip(this.rightMinCpsSlider, "Average amount of right clicks that will be sent to the game");
            this.rightMinCpsSlider.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.rightMinCpsSlider.Value = 125;
            this.rightMinCpsSlider.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.rightMinCpsSlider_Scroll);
            // 
            // leftMinCpsText
            // 
            this.PanelTransition.SetDecoration(this.leftMinCpsText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.leftMinCpsText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftMinCpsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.leftMinCpsText.Location = new System.Drawing.Point(363, 79);
            this.leftMinCpsText.Name = "leftMinCpsText";
            this.leftMinCpsText.Size = new System.Drawing.Size(35, 17);
            this.leftMinCpsText.TabIndex = 6;
            this.leftMinCpsText.Text = "12.5";
            this.leftMinCpsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.PanelTransition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(100, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Autoclicker configuration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.PanelTransition.SetDecoration(this.panel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel5.Location = new System.Drawing.Point(-139, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(558, 5);
            this.panel5.TabIndex = 2;
            // 
            // controlbar
            // 
            this.controlbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlbar.Controls.Add(this.guna2ImageButton1);
            this.controlbar.Controls.Add(this.watermarkImage);
            this.controlbar.Controls.Add(this.pictureBox2);
            this.controlbar.Controls.Add(this.guna2ControlBox2);
            this.controlbar.Controls.Add(this.guna2ControlBox1);
            this.controlbar.Controls.Add(this.panel7);
            this.PanelTransition.SetDecoration(this.controlbar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.controlbar.Location = new System.Drawing.Point(0, 5);
            this.controlbar.Name = "controlbar";
            this.controlbar.Size = new System.Drawing.Size(461, 45);
            this.controlbar.TabIndex = 4;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.PanelTransition.SetDecoration(this.guna2ImageButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.IndicateFocus = true;
            this.guna2ImageButton1.Location = new System.Drawing.Point(293, 7);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(39, 33);
            this.guna2ImageButton1.TabIndex = 10;
            // 
            // watermarkImage
            // 
            this.watermarkImage.BackgroundImage = global::Sapphire_LITE.Properties.Resources.Watermark;
            this.watermarkImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelTransition.SetDecoration(this.watermarkImage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.watermarkImage.Location = new System.Drawing.Point(32, 5);
            this.watermarkImage.Name = "watermarkImage";
            this.watermarkImage.Size = new System.Drawing.Size(139, 35);
            this.watermarkImage.TabIndex = 6;
            this.watermarkImage.TabStop = false;
            this.ToolTip.SetToolTip(this.watermarkImage, "Sapphire.ac");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Sapphire_LITE.Properties.Resources.Logo_with_glow___backgdasdsround;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelTransition.SetDecoration(this.pictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.PanelTransition.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.PanelTransition.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(386, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(47, 44);
            this.guna2ControlBox1.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PanelTransition.SetDecoration(this.panel7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel7.Location = new System.Drawing.Point(0, 44);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(461, 52);
            this.panel7.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.PanelTransition.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(18, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 248);
            this.panel3.TabIndex = 3;
            // 
            // LoadedConfigText
            // 
            this.LoadedConfigText.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.LoadedConfigText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LoadedConfigText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadedConfigText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadedConfigText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.LoadedConfigText.Location = new System.Drawing.Point(38, 318);
            this.LoadedConfigText.Name = "LoadedConfigText";
            this.LoadedConfigText.Size = new System.Drawing.Size(179, 18);
            this.LoadedConfigText.TabIndex = 29;
            this.LoadedConfigText.Text = "Loaded Config: None";
            this.LoadedConfigText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.UseTransparentDrag = true;
            // 
            // ToolTip
            // 
            this.ToolTip.AllowLinksHandling = true;
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ToolTip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ToolTip.ForeColor = System.Drawing.Color.White;
            this.ToolTip.InitialDelay = 300;
            this.ToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ToolTip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(86)))), ((int)(((byte)(168)))));
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // DragControl2
            // 
            this.DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl2.TargetControl = this.controlbar;
            this.DragControl2.UseTransparentDrag = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_NEGATIVE;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            // 
            // PanelTransition
            // 
            this.PanelTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(434, 338);
            this.Controls.Add(this.panel1);
            this.PanelTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sapphire.ac";
            this.ToolTip.SetToolTip(this, "Sapphire.ac");
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ConfigPanel.ResumeLayout(false);
            this.controlbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.watermarkImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer FadeInTimer;
        private System.Windows.Forms.Panel panel1;
        private FlatUI.FlatTrackBar leftMinCpsSlider;
        private System.Windows.Forms.Panel controlbar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label randomizationText;
        private System.Windows.Forms.Label label7;
        private FlatUI.FlatTrackBar randomizationSlider;
        private System.Windows.Forms.Label rightMinCpsText;
        private FlatUI.FlatTrackBar rightMinCpsSlider;
        private System.Windows.Forms.Label leftMinCpsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox watermarkImage;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2CheckBox toggleRandomization;
        private Guna.UI2.WinForms.Guna2ComboBox presetSelector;
        private Guna.UI2.WinForms.Guna2CheckBox toggleSmartMode;
        private Guna.UI2.WinForms.Guna2CheckBox toggleAlwaysOn;
        private Guna.UI2.WinForms.Guna2CheckBox toggleShiftDisable;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip;
        private Guna.UI2.WinForms.Guna2ShadowForm Shadow;
        private System.Windows.Forms.Label rightClickerBindButton;
        private System.Windows.Forms.Label leftClickerBindButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
        private FlatUI.FlatTrackBar rightMaxCpsSlider;
        private FlatUI.FlatTrackBar leftMaxCpsSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rightMaxCpsText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label leftMaxCpsText;
        private System.Windows.Forms.CheckBox LACCheck;
        private System.Windows.Forms.CheckBox RACCheck;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel ConfigPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2TextBox ConfigName;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label LoadedConfigText;
        private Guna.UI2.WinForms.Guna2Button Repair;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CircleButton AddAConfig;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2Transition PanelTransition;
        private Guna.UI2.WinForms.Guna2ComboBox configList;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private System.Windows.Forms.Label configStatus;
    }
}

