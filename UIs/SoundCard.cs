using System;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace PCInfos.UIs
{
    public partial class SoundCard : UserControl
    {
        public SoundCard()
        {
            InitializeComponent();
            Thread thread2 = new Thread(delegate () {
                Invoke((EventHandler)(delegate
                {
                    getSoundData();
                }));
            });
            thread2.Start();
        }

        // Функция для получения информации о звуковых устройствах и отображения ее на форме
        void getSoundData()
        {
            // Очищаем все вкладки в tabControl
            tabControl1.TabPages.Clear();
            // Создаем объект для поиска информации о звуковых устройствах в системе
            ManagementObjectSearcher myAudioObject = new ManagementObjectSearcher("select * from Win32_SoundDevice");

            // Перебираем все найденные звуковые устройства
            foreach (ManagementObject obj in myAudioObject.Get())
            {
                // Создаем новую вкладку с названием звуковой карты
                TabPage tabPage = new TabPage(obj["Name"].ToString());

                // Создаем новый label и добавляем на него информацию о звуковой карте
                Label label = new Label();
                label.AutoSize = true;
                label.Text = "Название: " + obj["Name"] + "\n" +
                             "Название продукта: " + obj["ProductName"] + "\n" +
                             "Доступность: " + obj["Availability"] + "\n" +
                             "Идентификатор устройства: " + obj["DeviceID"] + "\n" +
                             "Поддержка управления питанием: " + obj["PowerManagementSupported"] + "\n" +
                             "Статус: " + obj["Status"] + "\n" +
                             "Информация о статусе: " + obj["StatusInfo"];

                // Добавляем label на tabPage
                tabPage.Controls.Add(label);

                // Добавляем tabPage на tabControl
                tabControl1.TabPages.Add(tabPage);
            }
        }
    }
}
