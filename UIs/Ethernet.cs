using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace PCInfos.UIs
{
    public partial class Ethernet : UserControl
    {
        public Ethernet()
        {
            InitializeComponent();
            GetNetWorkInfo();
        }

        //Функция получения информации о сети.
        private void GetNetWorkInfo()
        {
            bool isDarkTheme = Theme.IsDarkTheme();
            Theme theme = new Theme(isDarkTheme);

            netList.BackColor = theme.getBackColor();
            netList.ForeColor = theme.getForeColor();
            progress.Value = 5; // Установка начального значения прогресс-бара.
            netList.GridLines = true; // Отображение сетки в ListView.
            netList.View = View.Details; // Установка отображения ListView в виде таблицы.
            netList.Columns.Add("Имя адаптера", -2, HorizontalAlignment.Left); // Добавление колонки с именем адаптера в ListView.
            progress.Value = 10; // Увеличение значения прогресс-бара.
                                 // Добавление остальных колонок с информацией в ListView.
            netList.Columns.Add("MAC-адрес", -2, HorizontalAlignment.Left);
            netList.Columns.Add("IP-адрес", -2, HorizontalAlignment.Left);
            netList.Columns.Add("Пропускная способность", -2, HorizontalAlignment.Left);
            netList.Columns.Add("Тип интерфейса", -2, HorizontalAlignment.Left);
            netList.Columns.Add("PING google.com", -2, HorizontalAlignment.Left);
            progress.Value = 15; // Увеличение значения прогресс-бара.

            // Установка ширины колонок в зависимости от ширины ListView.
            netList.Columns[0].Width = Convert.ToInt32(0.4 * netList.Width);
            netList.Columns[1].Width = Convert.ToInt32(0.25 * netList.Width);
            netList.Columns[2].Width = Convert.ToInt32(0.22 * netList.Width);
            netList.Columns[3].Width = Convert.ToInt32(0.14 * netList.Width);
            netList.Columns[4].Width = Convert.ToInt32(0.13 * netList.Width);
            netList.Columns[5].Width = Convert.ToInt32(0.38 * netList.Width);
            progress.Value = 20; // Увеличение значения прогресс-бара.

            netList.BeginUpdate(); // Начало обновления ListView.
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces(); // Получение информации обо всех сетевых адаптерах.
            foreach (NetworkInterface adapter in nics) // Перебор всех сетевых адаптеров.
            {
                progress.Value += 5; // Увеличение значения прогресс-бара.
                IPInterfaceProperties properties = adapter.GetIPProperties(); // Получение информации об IP-адресе сетевого адаптера.
                string[] row = new string[6]; // Создание строки с информацией о сетевом адаптере.
                row[0] = adapter.Description; // Добавление имени адаптера в строку.
                row[1] = adapter.GetPhysicalAddress().ToString(); // Добавление MAC-адреса адаптера в строку.
                foreach (UnicastIPAddressInformation ip in properties.UnicastAddresses) // Перебор всех IP-адресов адаптера.
                {
                    if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) // Проверка на IPv4-адрес.
                    {
                        row[2] = ip.Address.ToString(); // Добавление IP-адреса адаптера в строку.
                        break;
                    }
                }
                row[3] = (adapter.Speed / 1000000).ToString() + " Mbps";
                row[4] = adapter.NetworkInterfaceType.ToString();
                row[5] = Ping();
                netList.Items.Add(new ListViewItem(row));
            }
            progress.Value += 5;
            netList.EndUpdate();
            progress.Value = 0;
        }

        public string Ping()
        {
            string host = "google.com"; // Указываем хост, на который будет отправлен ping
            Ping p = new Ping(); // Создаем объект класса Ping
            PingReply reply = null; // Создаем переменную типа PingReply, которая будет содержать результат пинга
            try
            {
                reply = p.Send(host, 5000); // Отправляем пинг на указанный хост и ждем ответа не более 5 секунд
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // Выводим сообщение об ошибке в консоль, если возникает исключение
            }
            if (reply != null && reply.Status == IPStatus.Success) // Если результат пинга не пустой и статус успешный, то
            {
                return reply.RoundtripTime + "ms"; // возвращаем время отклика в миллисекундах
            }
            else // Иначе
            {
                return "Failed"; // возвращаем сообщение о неудачном пинге
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            netList.Items.Clear();
            netList.Clear();
            GetNetWorkInfo();
        }
    }
}
