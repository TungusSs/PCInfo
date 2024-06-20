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
            this.SoundCardLabel = new System.Windows.Forms.Label();
            this.CPULabel = new System.Windows.Forms.Label();
            this.GPULabel = new System.Windows.Forms.Label();
            this.PrinterLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.BIOSLabel = new System.Windows.Forms.Label();
            this.DiskLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.NetworkCardLabel = new System.Windows.Forms.Label();
            this.MainInfoLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modernstyyleCheck);
            this.groupBox1.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(93, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 82);
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
            this.groupBox2.Controls.Add(this.SoundCardLabel);
            this.groupBox2.Controls.Add(this.CPULabel);
            this.groupBox2.Controls.Add(this.GPULabel);
            this.groupBox2.Controls.Add(this.PrinterLabel);
            this.groupBox2.Controls.Add(this.OSLabel);
            this.groupBox2.Controls.Add(this.BIOSLabel);
            this.groupBox2.Controls.Add(this.DiskLabel);
            this.groupBox2.Controls.Add(this.TemperatureLabel);
            this.groupBox2.Controls.Add(this.NetworkCardLabel);
            this.groupBox2.Controls.Add(this.MainInfoLabel);
            this.groupBox2.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(93, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 238);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "О программе";
            // 
            // SoundCardLabel
            // 
            this.SoundCardLabel.AutoSize = true;
            this.SoundCardLabel.Location = new System.Drawing.Point(338, 200);
            this.SoundCardLabel.Name = "SoundCardLabel";
            this.SoundCardLabel.Size = new System.Drawing.Size(120, 17);
            this.SoundCardLabel.TabIndex = 10;
            this.SoundCardLabel.Text = "Звуковая карта";
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Location = new System.Drawing.Point(338, 160);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(80, 17);
            this.CPULabel.TabIndex = 9;
            this.CPULabel.Text = "Процессор";
            // 
            // GPULabel
            // 
            this.GPULabel.AutoSize = true;
            this.GPULabel.Location = new System.Drawing.Point(338, 120);
            this.GPULabel.Name = "GPULabel";
            this.GPULabel.Size = new System.Drawing.Size(192, 17);
            this.GPULabel.TabIndex = 8;
            this.GPULabel.Text = "Информация о видеокарте";
            // 
            // PrinterLabel
            // 
            this.PrinterLabel.AutoSize = true;
            this.PrinterLabel.Location = new System.Drawing.Point(338, 80);
            this.PrinterLabel.Name = "PrinterLabel";
            this.PrinterLabel.Size = new System.Drawing.Size(72, 17);
            this.PrinterLabel.TabIndex = 7;
            this.PrinterLabel.Text = "Принтера";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(338, 40);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(168, 17);
            this.OSLabel.TabIndex = 6;
            this.OSLabel.Text = "Операционная система";
            // 
            // BIOSLabel
            // 
            this.BIOSLabel.AutoSize = true;
            this.BIOSLabel.Location = new System.Drawing.Point(18, 120);
            this.BIOSLabel.Name = "BIOSLabel";
            this.BIOSLabel.Size = new System.Drawing.Size(248, 17);
            this.BIOSLabel.TabIndex = 5;
            this.BIOSLabel.Text = "Информация о BIOS и Мат. плате";
            // 
            // DiskLabel
            // 
            this.DiskLabel.AutoSize = true;
            this.DiskLabel.Location = new System.Drawing.Point(18, 200);
            this.DiskLabel.Name = "DiskLabel";
            this.DiskLabel.Size = new System.Drawing.Size(48, 17);
            this.DiskLabel.TabIndex = 4;
            this.DiskLabel.Text = "Диски";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Location = new System.Drawing.Point(18, 160);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(96, 17);
            this.TemperatureLabel.TabIndex = 3;
            this.TemperatureLabel.Text = "Температура";
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
            // MainInfoLabel
            // 
            this.MainInfoLabel.AutoSize = true;
            this.MainInfoLabel.Location = new System.Drawing.Point(18, 40);
            this.MainInfoLabel.Name = "MainInfoLabel";
            this.MainInfoLabel.Size = new System.Drawing.Size(216, 17);
            this.MainInfoLabel.TabIndex = 1;
            this.MainInfoLabel.Text = "Общая информация о системе";
            // 
            // SettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SettingsUI";
            this.Size = new System.Drawing.Size(700, 443);
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
        private System.Windows.Forms.Label DiskLabel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label NetworkCardLabel;
        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.Label GPULabel;
        private System.Windows.Forms.Label PrinterLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label SoundCardLabel;
    }
}
