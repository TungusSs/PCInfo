﻿namespace PCInfos.UIs
{
    partial class MainInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maininfolabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Общая информация о системе";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maininfolabel);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(17, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операционная система";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(17, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 81);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип системы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(7, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "\r\n";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(17, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(552, 81);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Первичная проверка памяти";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(7, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "\r\n";
            // 
            // saveBtn
            // 
            this.saveBtn.BorderRadius = 15;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Image = global::PCInfos.Properties.Resources.download_down_arrow_save_icon_145992;
            this.saveBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.saveBtn.Location = new System.Drawing.Point(389, 24);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(180, 28);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Сохранить в файл";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // MainInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainInfo";
            this.Size = new System.Drawing.Size(594, 428);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label maininfolabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
    }
}
