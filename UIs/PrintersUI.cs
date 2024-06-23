using System;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace PCInfos.UIs
{
    public partial class PrintersUI : UserControl
    {
        /// <summary>
        /// Конструктор, инициализирующий компонент и запускающий поток для получения данных о принтерах.
        /// </summary>
        public PrintersUI()
        {
            InitializeComponent();

            Thread thread2 = new Thread(delegate ()
            {
                // Используем Invoke для безопасного обновления UI из другого потока
                Invoke((EventHandler)(delegate
                {
                    // Установка шрифта, размера и стиля для метки
                    maininfolabel.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
                    maininfolabel.Text = getData();
                    // Получаем информацию о принтерах и отображаем её
                    GetPrinterInfo();
                }));
            });
            thread2.Start(); // Асинхронный запуск, чтобы не нагружать интерфейс
        }

        /// <summary>
        /// Метод, возвращающий строку с информацией о принтерах.
        /// </summary>
        /// <returns>Строка с информацией о принтерах.</returns>
        string getData()
        {
            string result = ""; // Создаем пустую строку, в которую будем добавлять данные о принтерах
            ManagementObjectSearcher myPrinterObject = new ManagementObjectSearcher("select * from Win32_Printer"); // Создаем объект для получения информации о принтерах

            foreach (ManagementObject obj in myPrinterObject.Get()) // Перебираем все объекты, полученные из запроса к WMI
            {
                string fi = obj["Default"].ToString() == "True" ? " - Основной" : ""; // Определяем, является ли принтер основным, и если да, то добавляем соответствующую метку
                result += "Название - " + obj["Name"] + fi + "\n"; // Добавляем информацию о принтере в итоговую строку
            }
            return result; // Возвращаем итоговую строку с информацией о принтерах
        }

        /// <summary>
        /// Метод для получения и отображения информации о принтерах.
        /// </summary>
        private void GetPrinterInfo()
        {
            // Включение сетки на списке принтеров
            printerList.GridLines = true;
            // Установка режима просмотра "Детали" на списке принтеров
            printerList.View = View.Details;
            // Добавление колонок в список принтеров с названием, сетевым статусом, основным статусом, ID устройства и статусом
            printerList.Columns.Add("Название", -2, HorizontalAlignment.Left);
            printerList.Columns.Add("Сетевой", -2, HorizontalAlignment.Center);
            printerList.Columns.Add("Основной", -2, HorizontalAlignment.Center);
            printerList.Columns.Add("ID устройства", -2, HorizontalAlignment.Center);
            printerList.Columns.Add("Статус", -2, HorizontalAlignment.Center);
            // Установка ширины каждой колонки на основе ширины списка принтеров
            printerList.Columns[0].Width = Convert.ToUInt16(0.25 * printerList.Width);
            printerList.Columns[1].Width = Convert.ToUInt16(0.1 * printerList.Width);
            printerList.Columns[2].Width = Convert.ToUInt16(0.15 * printerList.Width);
            printerList.Columns[3].Width = Convert.ToUInt16(0.25 * printerList.Width);
            printerList.Columns[4].Width = Convert.ToUInt16(0.2 * printerList.Width);

            // Запуск обновления списка принтеров
            printerList.BeginUpdate();

            // Создание объекта для поиска информации о принтерах
            ManagementObjectSearcher myPrinterObject = new ManagementObjectSearcher("select * from Win32_Printer");

            // Обход всех найденных принтеров и добавление их в список принтеров
            foreach (ManagementObject obj in myPrinterObject.Get())
            {
                ListViewItem printer_item = new ListViewItem();
                // Добавление названия принтера в первую колонку
                printer_item.Text = obj["Name"].ToString();
                // Добавление сетевого статуса во вторую колонку
                printer_item.SubItems.Add(obj["Network"].ToString() == "True" ? "Да" : "Нет");
                // Добавление основного статуса в третью колонку, если принтер является основным
                printer_item.SubItems.Add(obj["Default"].ToString() == "True" ? "Основной" : "");
                // Добавление ID устройства в четвертую колонку
                printer_item.SubItems.Add(obj["DeviceID"].ToString());
                // Добавление статуса принтера в пятую колонку
                printer_item.SubItems.Add(obj["Status"].ToString());
                // Добавление строки с информацией о принтере в список принтеров
                printerList.Items.Add(printer_item);
            }
            // Завершение обновления списка принтеров
            printerList.EndUpdate();
        }
    }
}
