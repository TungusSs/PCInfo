using LibreHardwareMonitor.Hardware;
using System;
using System.Collections;

namespace PCInfos
{
    /// <summary>
    /// Класс для чтения температуры процессора с использованием LibreHardwareMonitor.
    /// </summary>
    class CpuTemperatureReader : IDisposable
    {
        private Computer _computer;

        /// <summary>
        /// Конструктор класса, инициализирующий мониторинг процессора.
        /// </summary>
        public CpuTemperatureReader()
        {
            // Этот фрагмент кода создает новый экземпляр класса Computer и включает опцию мониторинга состояния процессора (IsCpuEnabled = true).
            // Затем он вызывает метод Open(), который запускает мониторинг аппаратных компонентов, таких как процессор,
            // и начинает получать информацию о температуре и других параметрах компонентов.
            _computer = new Computer
            {
                IsCpuEnabled = true,
            };
            _computer.Open();
        }

        /// <summary>
        /// Метод для получения температур ЦПУ в градусах Цельсия.
        /// </summary>
        /// <returns>Список температур в виде ArrayList.</returns>
        public ArrayList GetTemperaturesInCelsius()
        {
            ArrayList temperatures_list = new ArrayList();
            try
            {
                // Обход всех устройств и датчиков для получения температуры.
                foreach (var hardware in _computer.Hardware)
                {
                    hardware.Update(); // обновление информации об устройствах (можно использовать hardware.Name для получения модели ЦПУ)
                    if (hardware.HardwareType == HardwareType.Cpu) // проверяем, что это ЦПУ
                    {
                        foreach (var sensor in hardware.Sensors) // перебираем все датчики
                        {
                            if (sensor.SensorType == SensorType.Temperature && sensor.Value.HasValue) // проверяем, что это датчик температуры и значение не пустое
                            {
                                // Добавляем информацию о температуре в список
                                temperatures_list.Add(new Temperatures(sensor.Name, sensor.Value.Value,
                                sensor.Min.Value, sensor.Max.Value));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // выводим сообщение об ошибке в консоль, если что-то пошло не так
                Console.WriteLine(ex.Message);
            }

            // возвращаем список с температурами
            return temperatures_list;
        }

        /// <summary>
        /// Метод для освобождения ресурсов и закрытия мониторинга.
        /// </summary>
        public void Dispose()
        {
            try
            {
                _computer.Close();
            }
            catch (Exception)
            {
                // Можно добавить обработку исключения при закрытии.
            }
        }
    }
}
