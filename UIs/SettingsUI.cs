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
            toolTip.SetToolTip(TemperatureLabel, "Информация о температуре ядер и потоков процессора в реальном времени");
            toolTip.SetToolTip(DiskLabel, "Информация о типе диска, общем и доступном пространстве");
            toolTip.SetToolTip(OSLabel, "Информация о самой ОС, ее версия, код часового пояса,\nстраны, уровень шифрования и серийный номер");
            toolTip.SetToolTip(PrinterLabel, "Информация о принтерах, их количестве, \nID устройства, статусе, сетевой принтер или нет");
            toolTip.SetToolTip(GPULabel, "Информация о видеокарте, версии и каталоге драйвера,\nархитектура, тип видеопроцессора");
            toolTip.SetToolTip(CPULabel, "Информация о процессоре, производителе, ядрах и потоках,\nкод семейства и типа процессора");
            toolTip.SetToolTip(SoundCardLabel, "Информация о звуковой карте, названии продукта,\nстатусе, ID устройства");
        }

        private void modernstyyleCheck_CheckedChanged(object sender, EventArgs e)
        {
            SettingsHelper.setVisualGui(modernstyyleCheck.Checked);
            SettingsHelper.SaveSettings();
        }
    }
}
