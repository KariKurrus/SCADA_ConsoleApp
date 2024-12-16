using SCADA_ConsoleApp.Interfaces;

namespace SCADA_ConsoleApp.EntityLibrary.System
{
    public class PumpSystem : IContollableSystem
    {
        public string Name { get; set; }
        public bool IsRunning { get; private set; }

        public PumpSystem(string name)
        {
            Name = name;
            IsRunning = false;
        }

        public void Start()
        {
            IsRunning = true;

            Console.WriteLine($"{Name} is running.");
        }

        public void Stop()
        {
            IsRunning = false;

            Console.WriteLine($"{Name} is not running.");
        }
    }
}
