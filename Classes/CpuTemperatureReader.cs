using LibreHardwareMonitor.Hardware;
using System;
using System.Collections;

namespace PCInfos
{
    class CpuTemperatureReader : IDisposable
    {
        private Computer _computer;

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

        // Метод для получения температуры ЦПУ
        public ArrayList GetTemperaturesInCelsius()
        {
            ArrayList temperatures_list = new ArrayList();
            try
            {
                // Обход всех устройств и датчиков для получения температуры
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
                Console.WriteLine(ex.Message); // выводим сообщение об ошибке в консоль, если что-то пошло не так
            }

            return temperatures_list;// возвращаем список с температурами
        }

        public void Dispose()
        {
            try
            {
                _computer.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}
