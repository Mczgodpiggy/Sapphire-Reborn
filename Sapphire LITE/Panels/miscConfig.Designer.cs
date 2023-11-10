namespace Sapphire_Reborn
{
    partial class miscConfig
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.jitterYCheck = new Guna.UI2.WinForms.Guna2GradientButton();
            this.jitterXCheck = new Guna.UI2.WinForms.Guna2GradientButton();
            this.jitterYMaxText = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.jitterXMaxText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jitterIntervalText = new System.Windows.Forms.Label();
            this.jitterYMinText = new System.Windows.Forms.Label();
            this.jitterXMinText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.jitterInterval = new FlatUI.FlatTrackBar();
            this.JitterXMin = new FlatUI.FlatTrackBar();
            this.JitterXMax = new FlatUI.FlatTrackBar();
            this.JitterYMin = new FlatUI.FlatTrackBar();
            this.JitterYMax = new FlatUI.FlatTrackBar();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel4.Controls.Add(this.jitterInterval);
            this.panel4.Controls.Add(this.jitterYCheck);
            this.panel4.Controls.Add(this.jitterXCheck);
            this.panel4.Controls.Add(this.jitterYMaxText);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.jitterXMaxText);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.JitterXMin);
            this.panel4.Controls.Add(this.jitterIntervalText);
            this.panel4.Controls.Add(this.jitterYMinText);
            this.panel4.Controls.Add(this.jitterXMinText);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.JitterXMax);
            this.panel4.Controls.Add(this.JitterYMin);
            this.panel4.Controls.Add(this.JitterYMax);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(407, 260);
            this.panel4.TabIndex = 5;
            // 
            // jitterYCheck
            // 
            this.jitterYCheck.Animated = true;
            this.jitterYCheck.AnimatedGIF = true;
            this.jitterYCheck.BackColor = System.Drawing.Color.Transparent;
            this.jitterYCheck.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.jitterYCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(187)))), ((int)(((byte)(240)))));
            this.jitterYCheck.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.jitterYCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.jitterYCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.jitterYCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.jitterYCheck.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.jitterYCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.jitterYCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(215)))), ((int)(((byte)(247)))));
            this.jitterYCheck.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(215)))), ((int)(((byte)(247)))));
            this.jitterYCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.jitterYCheck.ForeColor = System.Drawing.Color.White;
            this.jitterYCheck.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.jitterYCheck.Location = new System.Drawing.Point(4, 113);
            this.jitterYCheck.Name = "jitterYCheck";
            this.jitterYCheck.Size = new System.Drawing.Size(12, 12);
            this.jitterYCheck.TabIndex = 33;
            this.jitterYCheck.UseTransparentBackground = true;
            this.jitterYCheck.CheckedChanged += new System.EventHandler(this.toggleJiterY);
            // 
            // jitterXCheck
            // 
            this.jitterXCheck.Animated = true;
            this.jitterXCheck.AnimatedGIF = true;
            this.jitterXCheck.BackColor = System.Drawing.Color.Transparent;
            this.jitterXCheck.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.jitterXCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(187)))), ((int)(((byte)(240)))));
            this.jitterXCheck.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.jitterXCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.jitterXCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.jitterXCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.jitterXCheck.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.jitterXCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.jitterXCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(215)))), ((int)(((byte)(247)))));
            this.jitterXCheck.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(215)))), ((int)(((byte)(247)))));
            this.jitterXCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.jitterXCheck.ForeColor = System.Drawing.Color.White;
            this.jitterXCheck.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.jitterXCheck.Location = new System.Drawing.Point(4, 45);
            this.jitterXCheck.Name = "jitterXCheck";
            this.jitterXCheck.Size = new System.Drawing.Size(12, 12);
            this.jitterXCheck.TabIndex = 32;
            this.jitterXCheck.UseTransparentBackground = true;
            this.jitterXCheck.CheckedChanged += new System.EventHandler(this.toggleJiterX);
            // 
            // jitterYMaxText
            // 
            this.jitterYMaxText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jitterYMaxText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.jitterYMaxText.Location = new System.Drawing.Point(363, 178);
            this.jitterYMaxText.Name = "jitterYMaxText";
            this.jitterYMaxText.Size = new System.Drawing.Size(40, 17);
            this.jitterYMaxText.TabIndex = 23;
            this.jitterYMaxText.Text = "0px";
            this.jitterYMaxText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label9.Location = new System.Drawing.Point(370, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "MAX";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jitterXMaxText
            // 
            this.jitterXMaxText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jitterXMaxText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.jitterXMaxText.Location = new System.Drawing.Point(363, 111);
            this.jitterXMaxText.Name = "jitterXMaxText";
            this.jitterXMaxText.Size = new System.Drawing.Size(40, 17);
            this.jitterXMaxText.TabIndex = 21;
            this.jitterXMaxText.Text = "0px";
            this.jitterXMaxText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
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
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label3.Location = new System.Drawing.Point(370, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "MIN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jitterIntervalText
            // 
            this.jitterIntervalText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jitterIntervalText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.jitterIntervalText.Location = new System.Drawing.Point(349, 195);
            this.jitterIntervalText.Name = "jitterIntervalText";
            this.jitterIntervalText.Size = new System.Drawing.Size(45, 17);
            this.jitterIntervalText.TabIndex = 12;
            this.jitterIntervalText.Text = "1 MS";
            this.jitterIntervalText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // jitterYMinText
            // 
            this.jitterYMinText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jitterYMinText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.jitterYMinText.Location = new System.Drawing.Point(363, 144);
            this.jitterYMinText.Name = "jitterYMinText";
            this.jitterYMinText.Size = new System.Drawing.Size(40, 17);
            this.jitterYMinText.TabIndex = 9;
            this.jitterYMinText.Text = "0px";
            this.jitterYMinText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jitterXMinText
            // 
            this.jitterXMinText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jitterXMinText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.jitterXMinText.Location = new System.Drawing.Point(363, 79);
            this.jitterXMinText.Name = "jitterXMinText";
            this.jitterXMinText.Size = new System.Drawing.Size(40, 17);
            this.jitterXMinText.TabIndex = 6;
            this.jitterXMinText.Text = "0px";
            this.jitterXMinText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(100, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Misc configuration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.panel5.Location = new System.Drawing.Point(-139, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(558, 5);
            this.panel5.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Jitter X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Jitter Y";
            // 
            // jitterInterval
            // 
            this.jitterInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.jitterInterval.ColorScheme1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.jitterInterval.ColorScheme2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.jitterInterval.Decimal = false;
            this.jitterInterval.FloatValue = 0D;
            this.jitterInterval.Full = false;
            this.jitterInterval.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.jitterInterval.Location = new System.Drawing.Point(16, 200);
            this.jitterInterval.Maximum = 100;
            this.jitterInterval.Minimum = 1;
            this.jitterInterval.Name = "jitterInterval";
            this.jitterInterval.ShowValue = false;
            this.jitterInterval.Size = new System.Drawing.Size(327, 12);
            this.jitterInterval.TabIndex = 39;
            this.jitterInterval.Text = "LMin";
            this.jitterInterval.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.jitterInterval.Value = 1;
            this.jitterInterval.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.jitterInterval_Scroll);
            // 
            // JitterXMin
            // 
            this.JitterXMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.JitterXMin.ColorScheme1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.JitterXMin.ColorScheme2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.JitterXMin.Decimal = false;
            this.JitterXMin.FloatValue = 0D;
            this.JitterXMin.Full = false;
            this.JitterXMin.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.JitterXMin.Location = new System.Drawing.Point(16, 64);
            this.JitterXMin.Maximum = 20;
            this.JitterXMin.Minimum = 0;
            this.JitterXMin.Name = "JitterXMin";
            this.JitterXMin.ShowValue = false;
            this.JitterXMin.Size = new System.Drawing.Size(355, 12);
            this.JitterXMin.TabIndex = 2;
            this.JitterXMin.Text = "LMin";
            this.JitterXMin.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.JitterXMin.Value = 0;
            this.JitterXMin.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.JitterXMin_Scroll);
            // 
            // JitterXMax
            // 
            this.JitterXMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.JitterXMax.ColorScheme1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.JitterXMax.ColorScheme2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.JitterXMax.Decimal = false;
            this.JitterXMax.FloatValue = 0D;
            this.JitterXMax.Full = false;
            this.JitterXMax.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.JitterXMax.Location = new System.Drawing.Point(16, 95);
            this.JitterXMax.Maximum = 20;
            this.JitterXMax.Minimum = 0;
            this.JitterXMax.Name = "JitterXMax";
            this.JitterXMax.ShowValue = false;
            this.JitterXMax.Size = new System.Drawing.Size(355, 12);
            this.JitterXMax.TabIndex = 36;
            this.JitterXMax.Text = "LMin";
            this.JitterXMax.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.JitterXMax.Value = 0;
            this.JitterXMax.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.JitterXMax_Scroll);
            // 
            // JitterYMin
            // 
            this.JitterYMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.JitterYMin.ColorScheme1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.JitterYMin.ColorScheme2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.JitterYMin.Decimal = false;
            this.JitterYMin.FloatValue = 0D;
            this.JitterYMin.Full = false;
            this.JitterYMin.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.JitterYMin.Location = new System.Drawing.Point(16, 132);
            this.JitterYMin.Maximum = 20;
            this.JitterYMin.Minimum = 0;
            this.JitterYMin.Name = "JitterYMin";
            this.JitterYMin.ShowValue = false;
            this.JitterYMin.Size = new System.Drawing.Size(355, 12);
            this.JitterYMin.TabIndex = 37;
            this.JitterYMin.Text = "LMin";
            this.JitterYMin.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.JitterYMin.Value = 0;
            this.JitterYMin.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.JitterYMin_Scroll);
            // 
            // JitterYMax
            // 
            this.JitterYMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.JitterYMax.ColorScheme1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.JitterYMax.ColorScheme2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.JitterYMax.Decimal = false;
            this.JitterYMax.FloatValue = 0D;
            this.JitterYMax.Full = false;
            this.JitterYMax.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.JitterYMax.Location = new System.Drawing.Point(16, 161);
            this.JitterYMax.Maximum = 20;
            this.JitterYMax.Minimum = 0;
            this.JitterYMax.Name = "JitterYMax";
            this.JitterYMax.ShowValue = false;
            this.JitterYMax.Size = new System.Drawing.Size(355, 12);
            this.JitterYMax.TabIndex = 38;
            this.JitterYMax.Text = "LMin";
            this.JitterYMax.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.JitterYMax.Value = 0;
            this.JitterYMax.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.JitterYMax_Scroll);
            // 
            // miscConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "miscConfig";
            this.Size = new System.Drawing.Size(407, 260);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2GradientButton jitterYCheck;
        private Guna.UI2.WinForms.Guna2GradientButton jitterXCheck;
        private System.Windows.Forms.Label jitterYMaxText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label jitterXMaxText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FlatUI.FlatTrackBar JitterXMin;
        private System.Windows.Forms.Label jitterIntervalText;
        private System.Windows.Forms.Label jitterYMinText;
        private System.Windows.Forms.Label jitterXMinText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private FlatUI.FlatTrackBar JitterXMax;
        private FlatUI.FlatTrackBar JitterYMin;
        private FlatUI.FlatTrackBar JitterYMax;
        private FlatUI.FlatTrackBar jitterInterval;
    }
}
