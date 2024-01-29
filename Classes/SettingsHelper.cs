using System;
using System.IO;

namespace PCInfos.Classes
{
    public class SettingsHelper
    {
        private static string settingsDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PCInfos");
        private static string settingsFilePath = Path.Combine(settingsDirectory, "settings.pcinfo");

        private static bool moderngui { get; set; }

        public static bool getVisualGui()
        {
            return moderngui;
        }

        public static void setVisualGui(bool value) { moderngui = value; }

        static SettingsHelper()
        {
            InitializeSettings();
        }

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
