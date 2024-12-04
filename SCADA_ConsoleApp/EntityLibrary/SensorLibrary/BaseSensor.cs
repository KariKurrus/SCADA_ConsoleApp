namespace SCADA_ConsoleApp.EntityLibrary.SensorLibrary
{
    public abstract class BaseSensor
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public double Value { get; protected set; }

        protected BaseSensor(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public abstract void ReadValue();

        public virtual void LogValue()
        {
            Console.WriteLine($"{Name}: {Description} - {Value}");
        }
    }
}
