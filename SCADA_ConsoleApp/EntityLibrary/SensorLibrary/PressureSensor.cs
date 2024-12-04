namespace SCADA_ConsoleApp.EntityLibrary.SensorLibrary
{
    public class PressureSensor : BaseSensor
    {
        private static readonly Random RandomGenerator = new();

        public PressureSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = RandomGenerator.NextDouble() * 10;
        }

        public override void LogValue()
        {
            Console.WriteLine($"{Name}: Pressure - {Value:F2} bars;");
        }
    }
}
