using System;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace PCInfos.UIs
{
    public partial class OperationSystemUI : UserControl
    {
        public OperationSystemUI()
        {
            InitializeComponent();
            Thread thread2 = new Thread(delegate () {
                Invoke((EventHandler)(delegate
                {
                    maininfolabel.Text = getData();
                }));
            });
            thread2.Start();
        }

        // Функция для получения информации о операционной системе
        string getData()
        {
            // Инициализация переменных
            string result = "";
            string osVersion = GetOSVersion();
            // Создание объекта для поиска информации об операционной системе
            ManagementObjectSearcher myOperativeSystemObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            // Получение информации об операционной системе и формирование строки с результатом
            foreach (ManagementObject obj in myOperativeSystemObject.Get())
            {
                result += "Название  -  " + obj["Caption"] + "\n";
                result += "Каталог Windows  -  " + obj["WindowsDirectory"] + "\n";
                result += "Тип продукта  -  " + obj["ProductType"] + "\n";
                result += "Серийный номер  -  " + obj["SerialNumber"] + "\n";
                result += "Системный каталог  -  " + obj["SystemDirectory"] + "\n";
                result += "Код страны  -  " + obj["CountryCode"] + "\n";
                result += "Текущий часовой пояс  -  " + obj["CurrentTimeZone"] + "\n";
                result += "Уровень шифрования  -  " + obj["EncryptionLevel"] + "\n";
                result += "Тип ОС  -  " + obj["OSType"] + "\n";
                result += "Версия  -  " + obj["Version"] + "\n";
            }

            // Установка изображения операционной системы в зависимости от версии
            SetOSImage(osVersion);

            // Возврат строки с информацией об операционной системе
            return result;
        }

        // Функция для получения версии операционной системы
        string GetOSVersion()
        {
            string osVersion = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select Version from Win32_OperatingSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                osVersion = obj["Version"].ToString();
            }
            return osVersion;
        }

        // Функция для установки изображения операционной системы в зависимости от версии
        void SetOSImage(string version)
        {
            Version currentVersion = new Version(version);

            if (currentVersion.Major == 10)
            {
                if (currentVersion >= new Version("10.0.22000.0"))
                {
                    pictureBox1.Image = Properties.Resources.Win11;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.Win10;
                }
            }
            else if (currentVersion.Major == 6 && (currentVersion.Minor == 0 || currentVersion.Minor == 1))
            {
                pictureBox1.Image = Properties.Resources.Win7;
            }
        }
    }
}
