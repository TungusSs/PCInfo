namespace PCInfos
{
    partial class ModernForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.user = new System.Windows.Forms.ToolStripStatusLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.headerPanel = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.swithTheme = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.renderP = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.panelmainBtnOn = new Guna.UI2.WinForms.Guna2Button();
            this.panelNetworkCardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelBiosBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelTempBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelDiskBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelOSBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelPrintersBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelGraphCardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelCPUBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelSoundCardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelSettingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.statusStrip1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.user});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(795, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // user
            // 
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(51, 17);
            this.user.Text = "UserInfo";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.guna2ControlBox2);
            this.headerPanel.Controls.Add(this.guna2ControlBox1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(795, 29);
            this.headerPanel.TabIndex = 3;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(699, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 5;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(750, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 4;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.headerPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(664, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Темная тема";
            // 
            // swithTheme
            // 
            this.swithTheme.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.swithTheme.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.swithTheme.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.swithTheme.CheckedState.InnerColor = System.Drawing.Color.White;
            this.swithTheme.Location = new System.Drawing.Point(754, 512);
            this.swithTheme.Name = "swithTheme";
            this.swithTheme.Size = new System.Drawing.Size(35, 18);
            this.swithTheme.TabIndex = 6;
            this.swithTheme.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.swithTheme.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.swithTheme.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.swithTheme.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.swithTheme.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged_1);
            // 
            // renderP
            // 
            this.renderP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderP.Location = new System.Drawing.Point(197, 29);
            this.renderP.Name = "renderP";
            this.renderP.Size = new System.Drawing.Size(598, 481);
            this.renderP.TabIndex = 4;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panelmainBtnOn);
            this.panelLeft.Controls.Add(this.panelNetworkCardBtn);
            this.panelLeft.Controls.Add(this.panelBiosBtn);
            this.panelLeft.Controls.Add(this.panelTempBtn);
            this.panelLeft.Controls.Add(this.panelDiskBtn);
            this.panelLeft.Controls.Add(this.panelOSBtn);
            this.panelLeft.Controls.Add(this.panelPrintersBtn);
            this.panelLeft.Controls.Add(this.panelGraphCardBtn);
            this.panelLeft.Controls.Add(this.panelCPUBtn);
            this.panelLeft.Controls.Add(this.panelSoundCardBtn);
            this.panelLeft.Controls.Add(this.panelSettingsBtn);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 29);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(197, 481);
            this.panelLeft.TabIndex = 0;
            // 
            // panelmainBtnOn
            // 
            this.panelmainBtnOn.BorderRadius = 15;
            this.panelmainBtnOn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panelmainBtnOn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panelmainBtnOn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panelmainBtnOn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panelmainBtnOn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelmainBtnOn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.panelmainBtnOn.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelmainBtnOn.ForeColor = System.Drawing.Color.White;
            this.panelmainBtnOn.Location = new System.Drawing.Point(3, 3);
            this.panelmainBtnOn.Name = "panelmainBtnOn";
            this.panelmainBtnOn.Size = new System.Drawing.Size(191, 45);
            this.panelmainBtnOn.TabIndex = 0;
            this.panelmainBtnOn.Text = "Общая информация о системе";
            this.panelmainBtnOn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panelNetworkCardBtn
            // 
            this.panelNetworkCardBtn.BorderRadius = 15;
            this.panelNetworkCardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panelNetworkCardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panelNetworkCardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panelNetworkCardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panelNetworkCardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNetworkCardBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.panelNetworkCardBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelNetworkCardBtn.ForeColor = System.Drawing.Color.White;
            this.panelNetworkCardBtn.Location = new System.Drawing.Point(3, 54);
            this.panelNetworkCardBtn.Name = "panelNetworkCardBtn";
            this.panelNetworkCardBtn.Size = new System.Drawing.Size(191, 31);
            this.panelNetworkCardBtn.TabIndex = 1;
            this.panelNetworkCardBtn.Text = "Сетевая карта";
            this.panelNetworkCardBtn.Click += new System.EventHandler(this.panelNetworkCardBtn_Click);
            // 
            // panelBiosBtn
            // 
            this.panelBiosBtn.BorderRadius = 15;
            this.panelBiosBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panelBiosBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panelBiosBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panelBiosBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panelBiosBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBiosBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.panelBiosBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelBiosBtn.ForeColor = System.Drawing.Color.White;
            this.panelBiosBtn.Location = new System.Drawing.Point(3, 91);
            this.panelBiosBtn.Name = "panelBiosBtn";
            this.panelBiosBtn.Size = new System.Drawing.Size(191, 31);
            this.panelBiosBtn.TabIndex = 2;
            this.panelBiosBtn.Text = "BIOS и Материнская плата";
            this.panelBiosBtn.Click += new System.EventHandler(this.panelBiosBtn_Click);
            // 
            // panelTempBtn
            // 
            this.panelTempBtn.BorderRadius = 15;
            this.panelTempBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panelTempBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panelTempBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panelTempBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panelTempBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTempBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.panelTempBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelTempBtn.ForeColor = System.Drawing.Color.White;
            this.panelTempBtn.Location = new System.Drawing.Point(3, 128);
            this.panelTempBtn.Name = "panelTempBtn";
            this.panelTempBtn.Size = new System.Drawing.Size(191, 31);
            this.panelTempBtn.TabIndex = 3;
            this.panelTempBtn.Text = "Температуры";
            this.panelTempBtn.Click += new System.EventHandler(this.guna2Button1_Click_2);
            // 
            // panelDiskBtn
            // 
            this.panelDiskBtn.BorderRadius = 15;
            this.panelDiskBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panelDiskBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panelDiskBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panelDiskBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panelDiskBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDiskBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.panelDiskBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelDiskBtn.ForeColor = System.Drawing.Color.White;
            this.panelDiskBtn.Location = new System.Drawing.Point(3, 165);
            this.panelDiskBtn.Name = "panelDiskBtn";
            this.panelDiskBtn.Size = new System.Drawing.Size(191, 31);
            this.panelDiskBtn.TabIndex = 4;
            this.panelDiskBtn.Text = "Диски";
            this.panelDiskBtn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // panelOSBtn
            // 
            this.panelOSBtn.BorderRadius = 15;
            this.panelOSBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panelOSBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panelOSBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panelOSBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panelOSBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOSBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.panelOSBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelOSBtn.ForeColor = System.Drawing.Color.White;
            this.panelOSBtn.Location = new System.Drawing.Point(3, 202);
            this.panelOSBtn.Name = "panelOSBtn";
            this.panelOSBtn.Size = new System.Drawing.Size(191, 31);
            this.panelOSBtn.TabIndex = 5;
            this.panelOSBtn.Text = "Операционная система";
            this.panelOSBtn.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // panelPrintersBtn
            // 
            this.panelPrintersBtn.BorderRadius = 15;
            this.panelPrintersBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panelPrintersBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panelPrintersBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panelPrintersBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panelPrintersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrintersBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.panelPrintersBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelPrintersBtn.ForeColor = System.Drawing.Color.White;
            this.panelPrintersBtn.Location = new System.Drawing.Point(3, 239);
            this.panelPrintersBtn.Name = "panelPrintersBtn";
            this.panelPrintersBtn.Size = new System.Drawing.Size(191, 31);
            this.panelPrintersBtn.TabIndex = 6;
            this.panelPrintersBtn.Text = "Принтера";
            this.panelPrintersBtn.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // panelGraphCardBtn
            // 
            this.panelGraphCardBtn.BorderRadius = 15;
            this.panelGraphCardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panelGraphCardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panelGraphCardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panelGraphCardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panelGraphCardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGraphCardBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.panelGraphCardBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelGraphCardBtn.ForeColor = System.Drawing.Color.White;
            this.panelGraphCardBtn.Location = new System.Drawing.Point(3, 276);
            this.panelGraphCardBtn.Name = "panelGraphCardBtn";
            this.panelGraphCardBtn.Size = new System.Drawing.Size(191, 31);
            this.panelGraphCardBtn.TabIndex = 7;
            this.panelGraphCardBtn.Text = "Информация о видеокарте";
            this.panelGraphCardBtn.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // panelCPUBtn
            // 
            this.panelCPUBtn.BorderRadius = 15;
            this.panelCPUBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panelCPUBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panelCPUBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panelCPUBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panelCPUBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCPUBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.panelCPUBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelCPUBtn.ForeColor = System.Drawing.Color.White;
            this.panelCPUBtn.Location = new System.Drawing.Point(3, 313);
            this.panelCPUBtn.Name = "panelCPUBtn";
            this.panelCPUBtn.Size = new System.Drawing.Size(191, 31);
            this.panelCPUBtn.TabIndex = 8;
            this.panelCPUBtn.Text = "Процессор";
            this.panelCPUBtn.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // panelSoundCardBtn
            // 
            this.panelSoundCardBtn.BorderRadius = 15;
            this.panelSoundCardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panelSoundCardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panelSoundCardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panelSoundCardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panelSoundCardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSoundCardBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.panelSoundCardBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelSoundCardBtn.ForeColor = System.Drawing.Color.White;
            this.panelSoundCardBtn.Location = new System.Drawing.Point(3, 350);
            this.panelSoundCardBtn.Name = "panelSoundCardBtn";
            this.panelSoundCardBtn.Size = new System.Drawing.Size(191, 31);
            this.panelSoundCardBtn.TabIndex = 9;
            this.panelSoundCardBtn.Text = "Звуковая карта";
            this.panelSoundCardBtn.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // panelSettingsBtn
            // 
            this.panelSettingsBtn.BorderRadius = 15;
            this.panelSettingsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panelSettingsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panelSettingsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panelSettingsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panelSettingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettingsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.panelSettingsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelSettingsBtn.ForeColor = System.Drawing.Color.White;
            this.panelSettingsBtn.Location = new System.Drawing.Point(3, 387);
            this.panelSettingsBtn.Name = "panelSettingsBtn";
            this.panelSettingsBtn.Size = new System.Drawing.Size(191, 31);
            this.panelSettingsBtn.TabIndex = 10;
            this.panelSettingsBtn.Text = "Настройки";
            this.panelSettingsBtn.Click += new System.EventHandler(this.guna2Button8_Click);
            // 
            // ModernForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(795, 532);
            this.Controls.Add(this.renderP);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swithTheme);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModernForm";
            this.Text = "ModernForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel user;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel headerPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch swithTheme;
        private System.Windows.Forms.FlowLayoutPanel renderP;
        private System.Windows.Forms.FlowLayoutPanel panelLeft;
        private Guna.UI2.WinForms.Guna2Button panelmainBtnOn;
        private Guna.UI2.WinForms.Guna2Button panelNetworkCardBtn;
        private Guna.UI2.WinForms.Guna2Button panelBiosBtn;
        private Guna.UI2.WinForms.Guna2Button panelTempBtn;
        private Guna.UI2.WinForms.Guna2Button panelDiskBtn;
        private Guna.UI2.WinForms.Guna2Button panelOSBtn;
        private Guna.UI2.WinForms.Guna2Button panelPrintersBtn;
        private Guna.UI2.WinForms.Guna2Button panelGraphCardBtn;
        private Guna.UI2.WinForms.Guna2Button panelCPUBtn;
        private Guna.UI2.WinForms.Guna2Button panelSoundCardBtn;
        private Guna.UI2.WinForms.Guna2Button panelSettingsBtn;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}