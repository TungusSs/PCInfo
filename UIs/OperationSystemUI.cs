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
            string osVersion = "";
            // Создание объекта для поиска информации об операционной системе
            ManagementObjectSearcher myOperativeSystemObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            // Получение информации об операционной системе и формирование строки с результатом
            foreach (ManagementObject obj in myOperativeSystemObject.Get())
            {
                osVersion = obj["Version"].ToString();
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
            if (osVersion.StartsWith("6.1") || osVersion.StartsWith("6.0"))
            {
                pictureBox1.Image = Properties.Resources.Win7;
            }
            else if (osVersion == "10.0.22000" || osVersion.StartsWith("11"))
            {
                pictureBox1.Image = Properties.Resources.Win11;
            }
            else if (osVersion.StartsWith("10.0"))
            {
                pictureBox1.Image = Properties.Resources.Win10;
            }

            // Возврат строки с информацией об операционной системе
            return result;

        }
    }
}
