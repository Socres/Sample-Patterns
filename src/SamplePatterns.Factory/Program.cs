namespace SamplePatterns.Factory
{
    using System;
    using System.Reflection;
    using SamplePatterns.Factory.Household;

    class Program
    {
        static void Main()
        {
            var machineFactory = LoadFactory();

            var machineName = "unkown";
            while (!string.IsNullOrEmpty(machineName))
            {
                Console.WriteLine("Enter machine name:");
                machineName = Console.ReadLine();

                var machine = machineFactory.CreateInstance(machineName);

                Console.WriteLine("Machine created: " + machine.Name);
                Console.WriteLine(machine.TurnOn());
                Console.WriteLine(machine.TurnOff());
                Console.WriteLine("*********");
            }
        }

        private static IMachineFactory LoadFactory()
        {
            var factoryName = Properties.Settings.Default.DefaultMachineFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IMachineFactory;
        }

    }
}
