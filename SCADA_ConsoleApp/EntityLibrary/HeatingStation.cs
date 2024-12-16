using SCADA_ConsoleApp.EntityLibrary.SensorLibrary;
using SCADA_ConsoleApp.EntityLibrary.System;

namespace SCADA_ConsoleApp.EntityLibrary
{
    public class HeatingStation
    {
        public List<BaseSensor> Sensors { get; }
        public CoolingSystem CoolingSystem { get; }
        public PumpSystem PumpSystem { get; }
        public FlowControlSystem FlowControlSystem { get; }

        public HeatingStation()
        {
            Sensors = new();
            CoolingSystem = new CoolingSystem("Cooling System");
            PumpSystem = new PumpSystem("Pump System");
            FlowControlSystem = new FlowControlSystem("Flow Control System");
        }

        public void DisplaySensors()
        {
            foreach (var sensor in Sensors)
            {
                sensor.ReadValue();
                sensor.LogValue();
            }
        }

        public void MonitorSensors()
        {
            foreach (var sensor in Sensors)
            {
                switch (sensor)
                {
                    case TemperatureSensor tempSensor when tempSensor.Value > 90:
                        CoolingSystem.Start();
                        break;

                    case TemperatureSensor tempSensor when tempSensor.Value < 50:
                        CoolingSystem.Stop();
                        break;

                    case PressureSensor pressureSensor when pressureSensor.Value < 2:
                        PumpSystem.Start();
                        break;

                    case PressureSensor pressureSensor when pressureSensor.Value > 5:
                        PumpSystem.Stop();
                        break;

                    case FlowSensor pressureSensor when pressureSensor.Value < 20:
                        FlowControlSystem.Start();
                        break;

                    case FlowSensor pressureSensor when pressureSensor.Value > 80:
                        FlowControlSystem.Stop();
                        break;
                }
            }
        }
    }
}
