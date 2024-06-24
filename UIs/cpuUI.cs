using System;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace PCInfos.UIs
{
    public partial class cpuUI : UserControl
    {
        /// <summary>
        /// Конструктор, инициализирующий компонент и запускающий поток для получения данных о процессоре.
        /// </summary>
        public cpuUI()
        {
            InitializeComponent();
            // Создаем и запускаем новый поток для получения информации о процессоре
            Thread th = new Thread(delegate ()
            {
                // Используем Invoke для безопасного обновления UI из другого потока
                Invoke((EventHandler)(delegate
                {
                    // Устанавливаем размер и шрифт для метки
                    maininfolabel.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
                    // Получаем информацию о процессоре и устанавливаем её в текст метки
                    maininfolabel.Text = GetProcessorInfo();
                }));
            });
            th.Start();
            // Этот код запускает новый поток с использованием лямбда-выражения для выполнения асинхронной операции получения информации о процессоре с помощью метода GetProcessorInfo().
            // Затем, используя метод Invoke, результат этого метода передается обратно в главный поток выполнения программы, где он обновляет текстовую метку maininfolabel с информацией о процессоре.
            // Таким образом, приложение продолжает работать и не блокируется во время выполнения операции получения информации.
        }

        /// <summary>
        /// Метод для получения информации о процессоре.
        /// </summary>
        /// <returns>Строка с информацией о процессоре.</returns>
        public string GetProcessorInfo()
        {
            string processorInfo = ""; // Создаем строку, в которую будем добавлять информацию о процессоре

            // Создаем объект для поиска информации о процессоре
            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");

            // Для каждого объекта, найденного с помощью поиска, добавляем информацию в строку processorInfo
            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                processorInfo += "Имя - " + obj["Name"] + Environment.NewLine; // Имя процессора
                processorInfo += "Идентификатор устройства - " + obj["DeviceID"] + Environment.NewLine; // Идентификатор процессора
                processorInfo += "Производитель - " + obj["Manufacturer"] + Environment.NewLine; // Производитель процессора
                processorInfo += "Текущая частота процессора - " + obj["CurrentClockSpeed"] + Environment.NewLine; // Текущая частота процессора
                processorInfo += "Описание - " + obj["Caption"] + Environment.NewLine; // Описание процессора
                processorInfo += "Количество ядер - " + obj["NumberOfCores"] + Environment.NewLine; // Количество ядер процессора
                processorInfo += "Количество активных ядер - " + obj["NumberOfEnabledCore"] + Environment.NewLine; // Количество активных ядер процессора
                processorInfo += "Количество логических процессоров - " + obj["NumberOfLogicalProcessors"] + Environment.NewLine; // Количество логических процессоров
                processorInfo += "Архитектура - " + obj["Architecture"] + Environment.NewLine; // Архитектура процессора
                processorInfo += "Семейство процессора - " + obj["Family"] + Environment.NewLine; // Семейство процессора
                processorInfo += "Тип процессора - " + obj["ProcessorType"] + Environment.NewLine; // Тип процессора
                processorInfo += "Характеристики - " + obj["Characteristics"] + Environment.NewLine; // Характеристики процессора
                processorInfo += "Ширина адреса - " + obj["AddressWidth"] + Environment.NewLine; // Ширина адреса процессора

                // Определяем производителя процессора по имени и устанавливаем соответствующее изображение
                string manufacturer = obj["Manufacturer"].ToString().ToLower();
                if (manufacturer.Contains("intel"))
                {
                    pictureBox1.Image = Properties.Resources.intel;
                }
                else if (manufacturer.Contains("amd"))
                {
                    pictureBox1.Image = Properties.Resources.amd;
                }
            }
            return processorInfo; // Возвращаем строку с информацией о процессоре
        }
    }
}
