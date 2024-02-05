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
            this.settingsUI1 = new PCInfos.UIs.SettingsUI();
            this.SuspendLayout();
            // 
            // settingsUI1
            // 
            this.settingsUI1.Location = new System.Drawing.Point(82, 12);
            this.settingsUI1.Name = "settingsUI1";
            this.settingsUI1.Size = new System.Drawing.Size(594, 428);
            this.settingsUI1.TabIndex = 0;
            // 
            // ModernForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settingsUI1);
            this.Name = "ModernForm";
            this.Text = "ModernForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UIs.SettingsUI settingsUI1;
    }
}