namespace PCInfos.UIs
{
    partial class SettingsUI
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modernstyyleCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MainInfoLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.NetworkCardLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BIOSLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modernstyyleCheck);
            this.groupBox1.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 82);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки отображения";
            // 
            // modernstyyleCheck
            // 
            this.modernstyyleCheck.AutoSize = true;
            this.modernstyyleCheck.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modernstyyleCheck.Location = new System.Drawing.Point(21, 36);
            this.modernstyyleCheck.Name = "modernstyyleCheck";
            this.modernstyyleCheck.Size = new System.Drawing.Size(195, 21);
            this.modernstyyleCheck.TabIndex = 0;
            this.modernstyyleCheck.Text = "Включить стиль modern";
            this.modernstyyleCheck.UseVisualStyleBackColor = true;
            this.modernstyyleCheck.CheckedChanged += new System.EventHandler(this.modernstyyleCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Настройки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BIOSLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TemperatureLabel);
            this.groupBox2.Controls.Add(this.NetworkCardLabel);
            this.groupBox2.Controls.Add(this.MainInfoLabel);
            this.groupBox2.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(16, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 232);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "О программе";
            // 
            // MainInfoLabel
            // 
            this.MainInfoLabel.AutoSize = true;
            this.MainInfoLabel.Location = new System.Drawing.Point(18, 42);
            this.MainInfoLabel.Name = "MainInfoLabel";
            this.MainInfoLabel.Size = new System.Drawing.Size(216, 17);
            this.MainInfoLabel.TabIndex = 1;
            this.MainInfoLabel.Text = "Общая информация о системе";
            // 
            // NetworkCardLabel
            // 
            this.NetworkCardLabel.AutoSize = true;
            this.NetworkCardLabel.Location = new System.Drawing.Point(18, 80);
            this.NetworkCardLabel.Name = "NetworkCardLabel";
            this.NetworkCardLabel.Size = new System.Drawing.Size(112, 17);
            this.NetworkCardLabel.TabIndex = 2;
            this.NetworkCardLabel.Text = "Сетевая карта";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Location = new System.Drawing.Point(18, 147);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(96, 17);
            this.TemperatureLabel.TabIndex = 3;
            this.TemperatureLabel.Text = "Температура";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Общая информация о системе";
            // 
            // BIOSLabel
            // 
            this.BIOSLabel.AutoSize = true;
            this.BIOSLabel.Location = new System.Drawing.Point(18, 114);
            this.BIOSLabel.Name = "BIOSLabel";
            this.BIOSLabel.Size = new System.Drawing.Size(248, 17);
            this.BIOSLabel.TabIndex = 5;
            this.BIOSLabel.Text = "Информация о BIOS и Мат. плате";
            // 
            // SettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SettingsUI";
            this.Size = new System.Drawing.Size(594, 443);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox modernstyyleCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label MainInfoLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label BIOSLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label NetworkCardLabel;
    }
}
