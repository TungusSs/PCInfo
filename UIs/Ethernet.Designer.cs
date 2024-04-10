namespace PCInfos.UIs
{
    partial class Ethernet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.netList = new System.Windows.Forms.ListView();
            this.maininfolabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progress = new Bunifu.Framework.UI.BunifuProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.netList);
            this.groupBox1.Controls.Add(this.maininfolabel);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(17, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 349);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблица отображения сети";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // netList
            // 
            this.netList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.netList.HideSelection = false;
            this.netList.Location = new System.Drawing.Point(6, 24);
            this.netList.Name = "netList";
            this.netList.Size = new System.Drawing.Size(540, 266);
            this.netList.TabIndex = 15;
            this.netList.UseCompatibleStateImageBehavior = false;
            // 
            // maininfolabel
            // 
            this.maininfolabel.AutoSize = true;
            this.maininfolabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maininfolabel.Location = new System.Drawing.Point(22, 37);
            this.maininfolabel.Name = "maininfolabel";
            this.maininfolabel.Size = new System.Drawing.Size(7, 15);
            this.maininfolabel.TabIndex = 0;
            this.maininfolabel.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Информация об интерфейсе сетевого подключения";
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.Silver;
            this.progress.BorderRadius = 5;
            this.progress.Location = new System.Drawing.Point(17, 412);
            this.progress.MaximumValue = 100;
            this.progress.Name = "progress";
            this.progress.ProgressColor = System.Drawing.Color.Teal;
            this.progress.Size = new System.Drawing.Size(552, 13);
            this.progress.TabIndex = 6;
            this.progress.Value = 0;
            // 
            // Ethernet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progress);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Ethernet";
            this.Size = new System.Drawing.Size(594, 428);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label maininfolabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView netList;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuProgressBar progress;
    }
}
