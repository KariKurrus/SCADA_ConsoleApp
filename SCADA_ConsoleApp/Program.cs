using SCADA_ConsoleApp.EntityLibrary;
using SCADA_ConsoleApp.EntityLibrary.SensorLibrary;

namespace SCADA_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var station = new HeatingStation();

            station.Sensors.Add(new TemperatureSensor("System Temperature", "Monitors the system temperature"));
            station.Sensors.Add(new PressureSensor("System Pressure", "Monitors the system pressure"));
            station.Sensors.Add(new FlowSensor("Flow Meter", "Monitors the flow rate"));

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"--- Step {i} ---");
                station.MonitorSensors();
                station.DisplaySensors();
                Console.WriteLine();
            }
        }
    }
}