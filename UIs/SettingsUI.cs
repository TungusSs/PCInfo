using PCInfos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCInfos.UIs
{
    public partial class SettingsUI : UserControl
    {
        public SettingsUI()
        {
            InitializeComponent();
            modernstyyleCheck.Checked = SettingsHelper.getVisualGui();
        }

        private void modernstyyleCheck_CheckedChanged(object sender, EventArgs e)
        {
            SettingsHelper.setVisualGui(modernstyyleCheck.Checked);
            SettingsHelper.SaveSettings();
        }
    }
}
