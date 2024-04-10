using System;
using System.Collections;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PCInfos.UIs
{
    public partial class TempUI : UserControl
    {
        public ListViewItem cpu_item = null;
        public ArrayList cpuTemper = null;
        public ArrayList networkList = null;
        private CpuTemperatureReader cpuCelsius;

        public TempUI()
        {
            InitializeComponent();
            cpuCelsius = new CpuTemperatureReader();

            timer1.Start();
            Thread thread4 = new Thread(delegate () {
                Invoke((EventHandler)(delegate
                {
                    GetCpuTemperatures();
                }));
            });
            thread4.Start();
        }
        private void GetCpuTemperatures()
        {
            // Включаем сетку для списка, устанавливаем вид списка на "Детали" и разрешаем прокручивание
            tempList.GridLines = true;
            tempList.View = View.Details;
            tempList.Scrollable = true;

            // Добавляем столбцы для отображения названия датчика, его значения, минимального и максимального значений
            tempList.Columns.Add("Название", -2, HorizontalAlignment.Left);
            tempList.Columns.Add("Значение", -2, HorizontalAlignment.Center);
            tempList.Columns.Add("Минимально", -2, HorizontalAlignment.Center);
            tempList.Columns.Add("Максимально", -2, HorizontalAlignment.Center);

            // Устанавливаем ширину столбцов в зависимости от ширины списка
            tempList.Columns[0].Width = Convert.ToUInt16(0.38 * tempList.Width);
            tempList.Columns[1].Width = Convert.ToUInt16(0.2 * tempList.Width);
            tempList.Columns[2].Width = Convert.ToUInt16(0.2 * tempList.Width);
            tempList.Columns[3].Width = Convert.ToUInt16(0.2 * tempList.Width);

            // Запускаем обновление списка
            tempList.BeginUpdate();

            // Получаем температуры процессора в градусах Цельсия и добавляем их в список
            cpuTemper = cpuCelsius.GetTemperaturesInCelsius();
            foreach (Temperatures temperatures in cpuTemper)
            {
                cpu_item = new ListViewItem
                {
                    Text = temperatures.name
                };
                cpu_item.SubItems.Add($"{temperatures.value:F1} °C");
                cpu_item.SubItems.Add($"{temperatures.minvalue:F1} °C");
                cpu_item.SubItems.Add($"{temperatures.maxvalue:F1} °C");
                tempList.Items.Add(cpu_item);
            }

            // Завершаем обновление списка
            tempList.EndUpdate();
        }


        public void UpdateCPUTemperatures()
        {
            // Получаем температуры ЦПУ
            cpuTemper = cpuCelsius.GetTemperaturesInCelsius();

            int i = 0;
            foreach (Temperatures temperatures in cpuTemper)
            {
                // Если температура превышает 55 градусов, меняем цвет текста на оранжевый
                if (temperatures.value >= 55 && i != 4)
                {
                    tempList.Items[i].ForeColor = Color.Orange;
                }
                // Если температура превышает 60 градусов для 5-го элемента, меняем цвет текста на красный
                else if (temperatures.value >= 60 && i == 4)
                {
                    tempList.Items[i].ForeColor = Color.Red;
                }
                // В остальных случаях меняем цвет текста на черный
                else
                {
                    tempList.Items[i].ForeColor = Color.Black;
                }

                // Обновляем значения температур в списке
                tempList.Items[i].SubItems[1].Text = $"{temperatures.value:F1} °C";
                tempList.Items[i].SubItems[2].Text = $"{temperatures.minvalue:F1} °C";
                tempList.Items[i].SubItems[3].Text = $"{temperatures.maxvalue:F1} °C";

                i++;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Invoke((EventHandler)(delegate
            {
                UpdateCPUTemperatures(); // инвокаем метод
            }));
        }
    }
}
