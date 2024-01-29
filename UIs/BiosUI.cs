using System;
using System.Management;
using System.Windows.Forms;

namespace PCInfos.UIs
{
    public partial class BiosUI : UserControl
    {
        public BiosUI()
        {
            InitializeComponent();
            // Устанавливаем значение текстового поля label2 с помощью метода GetBoardType()
            label2.Text = GetBoardType();
            // Устанавливаем значение текстового поля maininfolabel с помощью метода GetBios()
            maininfolabel.Text = GetBios();
        }

        // Объявляем статический метод GetBoardType() для получения информации о системной плате
        public static string GetBoardType()
        {
            try
            {
                var st = string.Empty;
                // Создаем объект для выполнения запроса WMI (Windows Management Instrumentation)
                var mos = new ManagementObjectSearcher("Select * from Win32_BaseBoard");
                // Получаем коллекцию объектов, соответствующих запросу WMI
                foreach (var o in mos.Get())
                {
                    var mo = (ManagementObject)o;
                    // Добавляем информацию о продукте системной платы в переменную st
                    st += $"Продукт: {mo["Product"]}\n";
                    // Добавляем информацию о производителе системной платы в переменную st
                    st += $"Производитель: {mo["Manufacturer"]}\n";
                    // Добавляем информацию о серийном номере системной платы в переменную st
                    st += $"Серийный номер: {mo["SerialNumber"]}\n";
                    // Добавляем информацию о версии системной платы в переменную st
                    st += $"Версия: {mo["Version"]}\n";
                }
                // Освобождаем ресурсы, связанные с объектом mos
                mos.Dispose();
                // Возвращаем строку с информацией о системной плате
                return st;
            }
            catch (Exception)
            {
                // Если возникает ошибка, возвращаем "неизвестно"
                return "неизвестно";
            }
        }

        // Объявляем статический метод GetBios() для получения информации о BIOS
        public static string GetBios()
        {
            try
            {
                // Создаем объект класса ManagementClass для доступа к WMI - классу "Win32_BIOS"
                ManagementClass mc = new ManagementClass("Win32_BIOS");
                // Получаем коллекцию экземпляров объектов класса Win32_BIOS
                ManagementObjectCollection moc = mc.GetInstances();
                // Объявляем переменную для хранения информации о BIOS
                string strID = null;
                // Перебираем каждый экземпляр объекта
                foreach (ManagementObject mo in moc)
                {
                    // Добавляем информацию о производителе BIOS, названии, серийном номере, дате выпуска, версии SMBIOSBIOS и версии
                    strID += $"Производитель: {mo.Properties["Manufacturer"].Value}\n";
                    strID += $"Название: {mo.Properties["Name"].Value}\n";
                    strID += $"Серийный номер: {mo.Properties["SerialNumber"].Value}\n";
                    strID += $"Дата выпуска: {mo.Properties["ReleaseDate"].Value}\n";
                    strID += $"Версия SMBIOSBIOS: {mo.Properties["SMBIOSBIOSVersion"].Value}\n";
                    strID += $"Версия: {mo.Properties["Version"].Value}\n";
                }
                // Освобождаем ресурсы, связанные с объектами
                mc = null;
                moc.Dispose();
                // Возвращаем информацию о BIOS
                return strID;
            }
            catch (Exception)
            {
                // Возвращаем строку "неизвестно" в случае ошибки
                return "неизвестно";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Очищаем текстовые поля
            label2.Text = "";
            maininfolabel.Text = "";
            // Получаем информацию о типе материнской платы и BIOS и отображаем их в соответствующих текстовых полях
            label2.Text = GetBoardType();
            maininfolabel.Text = GetBios();
        }
    }
}
