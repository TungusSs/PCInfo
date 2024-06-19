namespace PCInfos
{
    partial class WelcomeUI
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSystemClearButton = new Guna.UI2.WinForms.Guna2Button();
            this.panelVirusesClearButton = new Guna.UI2.WinForms.Guna2Button();
            this.panelTempFilesButton = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.Location = new System.Drawing.Point(108, 70);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(493, 27);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Добро пожаловать в приложение PCInfo!";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelSystemClearButton);
            this.flowLayoutPanel1.Controls.Add(this.panelTempFilesButton);
            this.flowLayoutPanel1.Controls.Add(this.panelVirusesClearButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(90, 159);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(528, 175);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelSystemClearButton
            // 
            this.panelSystemClearButton.BackColor = System.Drawing.Color.White;
            this.panelSystemClearButton.BorderColor = System.Drawing.Color.Transparent;
            this.panelSystemClearButton.BorderRadius = 10;
            this.panelSystemClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panelSystemClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panelSystemClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panelSystemClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panelSystemClearButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.panelSystemClearButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelSystemClearButton.ForeColor = System.Drawing.Color.White;
            this.panelSystemClearButton.Location = new System.Drawing.Point(3, 3);
            this.panelSystemClearButton.Name = "panelSystemClearButton";
            this.panelSystemClearButton.PressedColor = System.Drawing.Color.DimGray;
            this.panelSystemClearButton.Size = new System.Drawing.Size(170, 167);
            this.panelSystemClearButton.TabIndex = 3;
            this.panelSystemClearButton.Text = "Советы по уходу за своей системой";
            // 
            // panelVirusesClearButton
            // 
            this.panelVirusesClearButton.BackColor = System.Drawing.Color.Transparent;
            this.panelVirusesClearButton.BorderColor = System.Drawing.Color.Transparent;
            this.panelVirusesClearButton.BorderRadius = 10;
            this.panelVirusesClearButton.BorderThickness = 1;
            this.panelVirusesClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panelVirusesClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panelVirusesClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panelVirusesClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panelVirusesClearButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.panelVirusesClearButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelVirusesClearButton.ForeColor = System.Drawing.Color.White;
            this.panelVirusesClearButton.Location = new System.Drawing.Point(355, 3);
            this.panelVirusesClearButton.Name = "panelVirusesClearButton";
            this.panelVirusesClearButton.PressedColor = System.Drawing.Color.DimGray;
            this.panelVirusesClearButton.Size = new System.Drawing.Size(170, 167);
            this.panelVirusesClearButton.TabIndex = 4;
            this.panelVirusesClearButton.Text = "Очистка системы от вирусов";
            // 
            // panelTempFilesButton
            // 
            this.panelTempFilesButton.BackColor = System.Drawing.Color.White;
            this.panelTempFilesButton.BorderColor = System.Drawing.Color.Transparent;
            this.panelTempFilesButton.BorderRadius = 10;
            this.panelTempFilesButton.BorderThickness = 1;
            this.panelTempFilesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panelTempFilesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panelTempFilesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panelTempFilesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panelTempFilesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.panelTempFilesButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelTempFilesButton.ForeColor = System.Drawing.Color.White;
            this.panelTempFilesButton.Location = new System.Drawing.Point(179, 3);
            this.panelTempFilesButton.Name = "panelTempFilesButton";
            this.panelTempFilesButton.PressedColor = System.Drawing.Color.DimGray;
            this.panelTempFilesButton.Size = new System.Drawing.Size(170, 167);
            this.panelTempFilesButton.TabIndex = 5;
            this.panelTempFilesButton.Text = "Очистка системы от временных файлов";
            // 
            // WelcomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "WelcomeUI";
            this.Size = new System.Drawing.Size(720, 417);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button panelSystemClearButton;
        private Guna.UI2.WinForms.Guna2Button panelVirusesClearButton;
        private Guna.UI2.WinForms.Guna2Button panelTempFilesButton;
    }
}
