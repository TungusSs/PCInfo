using PCInfos.Classes;
using System;
using System.Windows.Forms;

namespace PCInfos.UIs
{
    public partial class SettingsUI : UserControl
    {
        public SettingsUI()
        {
            InitializeComponent();
            modernstyyleCheck.Checked = SettingsHelper.getVisualGui();

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(MainInfoLabel, "Информация о системе, модель устройства,\nсвободная оперативная память");
            toolTip.SetToolTip(NetworkCardLabel, "Информация о подключениях, MAC-адрес,\nпинг и т.п.");
            toolTip.SetToolTip(BIOSLabel, "Информация о версии, производителе,\nсерийный номер и т.п.");
            toolTip.SetToolTip(TemperatureLabel, "Информация о температуре CPU");
        }

        private void modernstyyleCheck_CheckedChanged(object sender, EventArgs e)
        {
            SettingsHelper.setVisualGui(modernstyyleCheck.Checked);
            SettingsHelper.SaveSettings();
        }
    }
}
