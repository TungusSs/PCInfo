using PCInfos.Classes;
using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace PCInfos
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Проверяем, запущено ли приложение с правами администратора
            if (!IsRunAsAdmin())
            {
                // Получаем имя приложения и аргументы командной строки
                string fileName = Application.ExecutablePath;
                string arguments = string.Join(" ", Environment.GetCommandLineArgs().Skip(1));

                // Запускаем процесс с правами администратора
                ProcessStartInfo psi = new ProcessStartInfo(fileName, arguments);
                psi.Verb = "runas"; // Запускаем с правами администратора
                Process.Start(psi);

                // Закрываем текущее приложение
                Application.Exit();
            }
            else
            {
                if (SettingsHelper.getVisualGui())
                {
                    // Запускаем главное окно приложения
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new ModernForm());
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Main());
                }
            }
        }

        /// <summary>
        /// Проверяем, запущено ли приложение с правами администратора
        /// </summary>
        /// <returns>Возвращает true, если приложение запущено с правами администратора</returns>
        public static bool IsRunAsAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
