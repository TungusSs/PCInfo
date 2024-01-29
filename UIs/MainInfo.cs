using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCInfos.UIs
{
    public partial class MainInfo : UserControl
    {
        public MainInfo()
        {
            InitializeComponent();
            // создание задач на получение информации об операционной системе, системе и памяти
            Task<string> task1 = Task.Run(() => CollectSystemInfo.GetOperatingSystemInfo());
            Task<string> task2 = Task.Run(() => CollectSystemInfo.GetSystemTypeInfo());
            Task<string> task3 = Task.Run(() => CollectSystemInfo.GetMemoryInfo());

            // установка текста метки maininfolabel после завершения первой задачи
            task1.ContinueWith(t => {
                maininfolabel.Text = t.Result;
            }, TaskScheduler.FromCurrentSynchronizationContext());

            // установка текста метки label2 после завершения второй задачи
            task2.ContinueWith(t => {
                label2.Text = t.Result;
            }, TaskScheduler.FromCurrentSynchronizationContext());

            // установка текста метки label3 после завершения третьей задачи
            task3.ContinueWith(t => {
                label3.Text = t.Result;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            // Получение всей информации и форматирование в одну строку
            string systemInfo = CollectSystemInfo.GetOperatingSystemInfo() + "\n" +
                                CollectSystemInfo.GetUserNameAndPcName() + "\n" +
                                CollectSystemInfo.GetProcessorInfo() + "\n" +
                                CollectSystemInfo.GetMemoryInfo() + "\n" +
                                CollectSystemInfo.GetSystemTypeInfo() + "\n" +
                                CollectSystemInfo.GetGraphicsInfo() + "\n" +
                                CollectSystemInfo.GetStorageInfo() + "\n" +
                                CollectSystemInfo.GetOpticalDriveInfo();

            // Задание пути к файлу для сохранения
            string filePath = "SystemInfo.txt";

            try
            {
                // Запись информации в файл
                File.WriteAllText(filePath, systemInfo);
                MessageBox.Show("Информация успешно сохранена в файле: " + filePath, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении информации: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
