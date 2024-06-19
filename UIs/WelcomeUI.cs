using System.Diagnostics;
using System.Windows.Forms;

namespace PCInfos
{
    public partial class WelcomeUI : UserControl
    {
        public WelcomeUI()
        {
            InitializeComponent();
            AttachButtonHandlers();
        }

        private void AttachButtonHandlers()
        {
            panelSystemClearButton.Click += (sender, e) => OpenUrl("https://example.com/system-clear-tips");
            panelVirusesClearButton.Click += (sender, e) => OpenUrl("https://example.com/virus-clear-tips");
            panelTempFilesButton.Click += (sender, e) => OpenUrl("https://example.com/temp-files-clear-tips");
        }

        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Не удалось открыть ссылку: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
