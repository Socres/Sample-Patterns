namespace SamplePatterns.Factory
{
    using System;
    using System.Reflection;
    using SamplePatterns.Factory.Household;

    class Program
    {
        static void Main(string[] args)
        {
            var machineFactory = LoadFactory();

            Console.WriteLine("Enter machine name:");
            var machineName = Console.ReadLine();

            var machine = machineFactory.CreateInstance(machineName);

            Console.WriteLine("Machine created: " + machine.Name);
            Console.WriteLine(machine.TurnOn());
            Console.WriteLine(machine.TurnOff());

            Console.ReadLine();
        }

        private static IMachineFactory LoadFactory()
        {
            var factoryName = Properties.Settings.Default.DefaultMachineFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IMachineFactory;
        }

    }
}
