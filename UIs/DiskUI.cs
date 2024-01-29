using System;
using System.Collections;
using System.IO;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace PCInfos.UIs
{
    public partial class DiskUI : UserControl
    {
        public DiskUI()
        {
            InitializeComponent();

            Thread thread2 = new Thread(delegate () {
                Invoke((EventHandler)(delegate
                {
                    maininfolabel.Text = getData();
                    GetDisks();
                }));
            });
            thread2.Start();
        }

        private void GetDisks()
        {
            // Устанавливаем свойства для ListView
            diskList.GridLines = true;
            diskList.View = View.Details;

            // Добавляем колонки в ListView
            diskList.Columns.Add("Модель диска", -2, HorizontalAlignment.Left);
            diskList.Columns.Add("Тип диска", -2, HorizontalAlignment.Center);
            diskList.Columns.Add("Размер диска", -2, HorizontalAlignment.Center);

            // Устанавливаем ширину колонок в соответствии с размером ListView
            diskList.Columns[0].Width = Convert.ToUInt16(0.6 * diskList.Width);
            diskList.Columns[1].Width = Convert.ToUInt16(0.15 * diskList.Width);
            diskList.Columns[2].Width = Convert.ToUInt16(0.2 * diskList.Width);

            // Начинаем обновление ListView
            diskList.BeginUpdate();

            // Получаем информацию о дисках
            ArrayList disk_info = GetDiskInfo();

            // Добавляем информацию о каждом диске в ListView
            foreach (DiskInfo disk in disk_info)
            {
                var disk_item = new ListViewItem
                {
                    Text = disk.name
                };
                disk_item.SubItems.Add(disk.type);
                disk_item.SubItems.Add((disk.size / 1024 / 1024 / 1024).ToString("f1") + " GB");
                diskList.Items.Add(disk_item);
            }

            // Заканчиваем обновление ListView
            diskList.EndUpdate();
        }


        // Метод для получения информации о дисках
        public static ArrayList GetDiskInfo()
        {
            try
            {
                // Создаем экземпляр класса ManagementClass для получения информации о дисках
                ManagementClass mc = new ManagementClass("Win32_DiskDrive");
                // Получаем коллекцию экземпляров класса ManagementObject, которые представляют дисковые накопители
                ManagementObjectCollection moc = mc.GetInstances();
                // Создаем пустой ArrayList для хранения информации о дисках
                ArrayList disk_list = new ArrayList();
                // Проходимся по каждому экземпляру класса ManagementObject в коллекции
                foreach (ManagementObject m in moc)
                {
                    // Проверяем, что свойство Size не равно null
                    if (m.Properties["Size"].Value != null)
                    {
                        // Создаем новый объект DiskInfo, содержащий информацию о диске
                        disk_list.Add(new DiskInfo(m.Properties["Caption"].Value.ToString(),
                        m.Properties["InterfaceType"].Value.ToString(),
                        Convert.ToDouble(m.Properties["Size"].Value)));
                    }
                }
                // Освобождаем ресурсы
                mc = null;
                moc.Dispose();
                // Возвращаем список дисков
                return disk_list;
            }
            catch (Exception)
            {
                // Если произошла ошибка, возвращаем null
                return null;
            }
        }
        // Метод, который возвращает информацию о всех дисках, подключенных к компьютеру.
        // Использует метод GetDrives() из класса DriveInfo для получения информации о каждом диске.
        // Возвращает строку с информацией о каждом диске, его типе, метке тома, файловой системе и объемах свободного и общего пространства на диске.
        public string getData()
        {
            string result = "";
            // Получение списка всех дисков с помощью метода GetDrives() из класса DriveInfo.
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            // Обработка каждого диска в списке.
            foreach (DriveInfo d in allDrives)
            {
                // Добавление информации о диске в строку результата.
                result += $"Диск {d.Name}\n";
                result += $"  Тип диска: {d.DriveType}\n";

                // Если диск доступен, добавление информации о метке тома, файловой системе и объемах свободного и общего пространства на диске.
                if (d.IsReady == true)
                {
                    result += $"  Метка тома: {d.VolumeLabel}\n";
                    result += $"  Файловая система: {d.DriveFormat} \n";
                    result += $"  Доступное пространство для текущего пользователя: {SizeSuffix(d.AvailableFreeSpace)}\n";
                    result += $"  Общее доступное пространство: {SizeSuffix(d.TotalFreeSpace)}\n";
                    result += $"  Общий размер диска: {SizeSuffix(d.TotalSize)}\n";
                    result += $"  Корневой каталог: {d.RootDirectory}\n";
                }
            }

            // Возвращение строки с информацией о дисках.
            return result;

        }
        // Суффиксы размерности для использования в SizeSuffix
        static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        // Функция конвертации числа в строку с добавлением соответствующего суффикса размерности
        static string SizeSuffix(Int64 value)
        {
            if (value < 0) { return "-" + SizeSuffix(-value); }
            if (value == 0) { return "0.0 bytes"; }

            int mag = (int)Math.Log(value, 1024); // Вычисляем порядок размерности
            decimal adjustedSize = (decimal)value / (1L << (mag * 10)); // Конвертируем число в соответствующую размерность

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]); // Возвращаем строку в формате "{0} {1}", где {0} - число, {1} - соответствующий суффикс
        }
    }
}
