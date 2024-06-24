using System;
using System.IO;

namespace PCInfos.Classes
{
    public class SettingsHelper
    {
        // Путь к директории настроек
        private static string settingsDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PCInfos");
        // Путь к файлу настроек
        private static string settingsFilePath = Path.Combine(settingsDirectory, "settings.pcinfo");

        // Свойство для хранения состояния графического интерфейса
        private static bool moderngui { get; set; }

        /// <summary>
        /// Метод для получения значения настройки графического интерфейса.
        /// </summary>
        /// <returns>Значение настройки графического интерфейса.</returns>
        public static bool getVisualGui()
        {
            return moderngui;
        }

        /// <summary>
        /// Метод для установки значения настройки графического интерфейса.
        /// </summary>
        /// <param name="value">Новое значение настройки графического интерфейса.</param>
        public static void setVisualGui(bool value)
        {
            moderngui = value;
        }

        // Статический конструктор, вызывающий метод инициализации настроек
        static SettingsHelper()
        {
            InitializeSettings();
        }

        /// <summary>
        /// Метод для инициализации настроек. Создает директорию и файл настроек, если они отсутствуют.
        /// </summary>
        private static void InitializeSettings()
        {
            if (!Directory.Exists(settingsDirectory))
            {
                Directory.CreateDirectory(settingsDirectory);
            }

            if (File.Exists(settingsFilePath))
            {
                LoadSettings();
            }
            else
            {
                moderngui = false;
                SaveSettings();
            }
        }

        /// <summary>
        /// Метод для загрузки настроек из файла.
        /// </summary>
        private static void LoadSettings()
        {
            try
            {
                string[] lines = File.ReadAllLines(settingsFilePath);

                foreach (var line in lines)
                {
                    string[] parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        string settingName = parts[0].Trim();
                        string settingValue = parts[1].Trim();

                        switch (settingName)
                        {
                            case "ModernGUI":
                                moderngui = bool.Parse(settingValue);
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка загрузки настроек: " + ex.Message);
            }
        }

        /// <summary>
        /// Метод для сохранения текущих настроек в файл.
        /// </summary>
        public static void SaveSettings()
        {
            try
            {
                string[] lines = {
                    $"ModernGUI={moderngui}",
                };

                File.WriteAllLines(settingsFilePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка сохранения настроек: " + ex.Message);
            }
        }
    }
}
