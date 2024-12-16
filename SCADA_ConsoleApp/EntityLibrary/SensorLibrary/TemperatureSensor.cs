namespace SCADA_ConsoleApp.EntityLibrary.SensorLibrary
{
    public class TemperatureSensor : BaseSensor
    {
        private static readonly Random RandomGenerator = new();

        public TemperatureSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = RandomGenerator.NextDouble() * 150;
        }

        public override void LogValue()
        {
            Console.WriteLine($"{Name}: Temperature - {Value:F2}°C;");
        }
    }
}
