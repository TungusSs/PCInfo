using System;
using System.Management;

namespace PCInfos
{
    /// <summary>
    /// Статический класс для сбора информации о системе.
    /// </summary>
    public static class CollectSystemInfo
    {
        /// <summary>
        /// Получение информации об операционной системе.
        /// </summary>
        /// <returns>Информация об операционной системе в виде строки.</returns>
        public static string GetOperatingSystemInfo()
        {
            string systemInfo = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption, Version, InstallDate, BuildNumber, SerialNumber, CSName FROM Win32_OperatingSystem");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                systemInfo += "Операционная система: " + queryObj["Caption"] + " " + queryObj["Version"] + " (" + queryObj["BuildNumber"] + ")\n";
                systemInfo += "Дата установки: " + ManagementDateTimeConverter.ToDateTime(queryObj["InstallDate"].ToString()).ToString("yyyy-MM-dd HH:mm:ss") + "\n";
                systemInfo += "Серийный номер: " + queryObj["SerialNumber"] + "\n";
                systemInfo += "Имя устройства: " + queryObj["CSName"] + "\n";
            }
            if (systemInfo == "") { return "Нет данных"; }
            return systemInfo;
        }

        /// <summary>
        /// Получение имени пользователя и имени компьютера.
        /// </summary>
        /// <returns>Имя компьютера и имя пользователя в виде строки.</returns>
        public static string GetUserNameAndPcName()
        {
            string systemInfo = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption, Version, InstallDate, BuildNumber, SerialNumber, CSName FROM Win32_OperatingSystem");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                systemInfo += queryObj["CSName"] + "/";
            }
            if (systemInfo == "") { return "Нет данных"; }
            return systemInfo + Environment.UserName;
        }

        /// <summary>
        /// Получение информации о процессоре.
        /// </summary>
        /// <returns>Информация о процессоре в виде строки.</returns>
        public static string GetProcessorInfo()
        {
            string systemInfo = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Name, Manufacturer, MaxClockSpeed, NumberOfCores, NumberOfLogicalProcessors FROM Win32_Processor");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                systemInfo += "Процессор: " + queryObj["Name"] + " (" + queryObj["Manufacturer"] + ")\n";
                systemInfo += "Максимальная частота: " + queryObj["MaxClockSpeed"] + " MHz\n";
                systemInfo += "Количество ядер: " + queryObj["NumberOfCores"] + "\n";
                systemInfo += "Количество логических процессоров: " + queryObj["NumberOfLogicalProcessors"] + "\n";
            }
            if (systemInfo == "") { return "Нет данных"; }
            return systemInfo;
        }

        /// <summary>
        /// Получение информации о памяти.
        /// </summary>
        /// <returns>Информация о памяти в виде строки.</returns>
        public static string GetMemoryInfo()
        {
            string systemInfo = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                ulong memorySize = Convert.ToUInt64(queryObj["TotalPhysicalMemory"]);
                double memorySizeGB = memorySize / (1024.0 * 1024.0 * 1024.0);
                systemInfo += "Память: " + memorySizeGB.ToString("F2") + " GB\n";
            }
            if (systemInfo == "") { return "Нет данных"; }
            return systemInfo;
        }

        /// <summary>
        /// Получение информации о типе системы.
        /// </summary>
        /// <returns>Информация о типе системы в виде строки.</returns>
        public static string GetSystemTypeInfo()
        {
            string systemInfo = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Name FROM Win32_ComputerSystemProduct");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                systemInfo += "Тип системы: " + queryObj["Name"] + "\n";
            }
            if (systemInfo == "") { return "Нет данных"; }
            return systemInfo;
        }

        /// <summary>
        /// Получение информации об устройствах графики.
        /// </summary>
        /// <returns>Информация об устройствах графики в виде строки.</returns>
        public static string GetGraphicsInfo()
        {
            string graphicsInfo = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_VideoController");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                graphicsInfo += "Графическое устройство: " + queryObj["Caption"] + "\n";
            }
            if (graphicsInfo == "") { return "Нет данных"; }
            return graphicsInfo;
        }

        /// <summary>
        /// Получение информации об устройствах хранения.
        /// </summary>
        /// <returns>Информация об устройствах хранения в виде строки.</returns>
        public static string GetStorageInfo()
        {
            string systemInfo = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_DiskDrive WHERE MediaType='Fixed hard disk media'");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                systemInfo += "Устройство хранения: " + queryObj["Caption"] + "\n";
            }
            if (systemInfo == "") { return "Нет данных"; }
            return systemInfo;
        }

        /// <summary>
        /// Получение информации об оптических устройствах.
        /// </summary>
        /// <returns>Информация об оптических устройствах в виде строки.</returns>
        public static string GetOpticalDriveInfo()
        {
            string systemInfo = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_CDROMDrive");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                systemInfo += "Оптическое устройство: " + queryObj["Caption"] + "\n";
            }
            if (systemInfo == "") { return "Оптическое устройство: Нет данных"; }
            return systemInfo;
        }
    }
}
