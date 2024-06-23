using System;
using System.Drawing;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace PCInfos.UIs
{
    public partial class VideocardUI : UserControl
    {
        /// <summary>
        /// Конструктор, инициализирующий компонент и запускающий поток для получения данных о видеокартах.
        /// </summary>
        public VideocardUI()
        {
            InitializeComponent();
            // Создаем и запускаем новый поток для получения информации о видеокартах
            Thread thread2 = new Thread(delegate () {
                // Используем Invoke для безопасного обновления UI из другого потока
                Invoke((EventHandler)(delegate
                {
                    // Получаем информацию о видеокартах и отображаем её
                    GetVideoInfo();
                }));
            });
            thread2.Start();
        }

        /// <summary>
        /// Метод для получения и отображения информации о видеокартах.
        /// </summary>
        private void GetVideoInfo()
        {
            // Очищаем все вкладки
            tabControl1.TabPages.Clear();

            // Создаем объект ManagementObjectSearcher для получения информации о видеокартах
            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");

            // Проверяем, активна ли темная тема
            bool isDarkTheme = Theme.IsDarkTheme();
            Theme theme = new Theme(isDarkTheme);

            // Начинаем добавлять вкладки для каждой найденной видеокарты
            int tabPageIndex = 1;
            foreach (ManagementObject obj in myVideoObject.Get())
            {
                // Получаем информацию о видеокарте
                string videoName = obj["Name"].ToString();
                string videoStatus = obj["Status"].ToString();
                string videoCaption = obj["Caption"].ToString();
                string videoDeviceID = obj["DeviceID"].ToString();
                string videoAdapterRAM = (Convert.ToInt64(obj["AdapterRAM"]) / (1024 * 1024)).ToString() + " MB";
                string videoAdapterDACType = obj["AdapterDACType"].ToString();
                string videoMonochrome = obj["Monochrome"].ToString();
                string videoInstalledDisplayDrivers = obj["InstalledDisplayDrivers"].ToString();
                string videoDriverVersion = obj["DriverVersion"].ToString();
                string videoProcessor = obj["VideoProcessor"].ToString();
                string videoArchitecture = obj["VideoArchitecture"].ToString();
                string videoMemoryType = obj["VideoMemoryType"].ToString();

                // Создаем новую вкладку для данной видеокарты
                TabPage tabPage = new TabPage();
                tabPage.Name = "tabPage" + tabPageIndex;
                tabPage.Text = videoName;
                // Устанавливаем цвет фона и текста вкладки в зависимости от темы
                tabPage.BackColor = theme.getBackColor();
                tabPage.ForeColor = theme.getForeColor();

                // Создаем метку для отображения информации о видеокарте на вкладке
                Label label = new Label();
                label.AutoSize = true;
                label.Location = new Point(10, 10);
                label.Text = @"Статус: " + videoStatus + "\n" +
                             @"Описание: " + videoCaption + "\n" +
                             @"Идентификатор устройства: " + videoDeviceID + "\n" +
                             @"Объем видеопамяти: " + videoAdapterRAM + "\n" +
                             @"Тип видеопроцессора: " + videoAdapterDACType + "\n" +
                             @"Монохромный: " + videoMonochrome + "\n" +
                             @"Установленные драйверы отображения: " + videoInstalledDisplayDrivers + "\n" +
                             @"Версия драйвера: " + videoDriverVersion + "\n" +
                             @"Процессор видео: " + videoProcessor + "\n" +
                             @"Архитектура видеопроцессора: " + videoArchitecture + "\n" +
                             @"Тип памяти видеокарты: " + videoMemoryType + "\n";

                // Добавляем метку на вкладку и добавляем вкладку в элемент управления TabControl
                tabPage.Controls.Add(label);
                tabPageIndex++;

                // Добавляем вкладку в элемент управления TabControl
                tabControl1.TabPages.Add(tabPage);
            }
        }
    }
}
