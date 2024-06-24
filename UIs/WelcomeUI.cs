using System.Diagnostics;
using System.Windows.Forms;

namespace PCInfos
{
    public partial class WelcomeUI : UserControl
    {
        /// <summary>
        /// Конструктор, инициализирующий компонент и назначающий обработчики кнопок.
        /// </summary>
        public WelcomeUI()
        {
            InitializeComponent();
            AttachButtonHandlers();
        }

        /// <summary>
        /// Метод для назначения обработчиков событий для кнопок.
        /// </summary>
        private void AttachButtonHandlers()
        {
            // Назначаем обработчик для кнопки очистки системы
            panelSystemClearButton.Click += (sender, e) => OpenUrl("https://dtf.ru/howto/256417-ultimativnyi-gaid-po-nastroike-i-optimizacii-windows-10");
            // Назначаем обработчик для кнопки очистки вирусов
            panelVirusesClearButton.Click += (sender, e) => OpenUrl("https://www.kaspersky.ru/resource-center/threats/how-to-get-rid-of-a-computer-virus");
            // Назначаем обработчик для кнопки очистки временных файлов
            panelTempFilesButton.Click += (sender, e) => OpenUrl("https://support.microsoft.com/ru-ru/windows/%D0%BE%D1%81%D0%B2%D0%BE%D0%B1%D0%BE%D0%B6%D0%B4%D0%B5%D0%BD%D0%B8%D0%B5-%D0%BC%D0%B5%D1%81%D1%82%D0%B0-%D0%BD%D0%B0-%D0%B4%D0%B8%D1%81%D0%BA%D0%B5-%D0%B2-windows-a18fae02-a0fa-8df9-9838-8970f9939de4");
        }

        /// <summary>
        /// Метод для открытия URL в браузере.
        /// </summary>
        /// <param name="url">URL для открытия.</param>
        private void OpenUrl(string url)
        {
            try
            {
                // Пытаемся открыть URL в браузере по умолчанию
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (System.Exception ex)
            {
                // В случае ошибки показываем сообщение об ошибке
                MessageBox.Show($"Не удалось открыть ссылку: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
