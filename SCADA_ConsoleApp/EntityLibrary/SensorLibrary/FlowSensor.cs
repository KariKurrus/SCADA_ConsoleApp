namespace SCADA_ConsoleApp.EntityLibrary.SensorLibrary
{
    public class FlowSensor : BaseSensor
    {
        private static readonly Random RandomGenerator = new();

        public FlowSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = RandomGenerator.NextDouble() * 100;

            Console.WriteLine($"{Name}: Flow - {Value:F2} m3/h;");
        }
    }
}
