namespace SamplePatterns.Factory.Household
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using SamplePatterns.Factory.Household.Machines;

    public class MachineFactory : IMachineFactory
    {
        private readonly Dictionary<string, Type> _machines;

        public MachineFactory()
        {
            _machines = new Dictionary<string, Type>();

            LoadTypesICanReturn();
        }

        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="description">The description.</param>
        /// <returns>An instance of the IMachine</returns>
        public IMachine CreateInstance(string description)
        {
            var type = GetTypeToCreate(description);

            if (type == null)
            {
                return new UnknownMachine();
            }

            return Activator.CreateInstance(type) as IMachine;
        }

        /// <summary>
        /// Gets the type to create.
        /// </summary>
        /// <param name="machineName">Name of the machine.</param>
        /// <returns>The typeof the machine</returns>
        private Type GetTypeToCreate(string machineName)
        {
            return 
                (from machine in _machines 
                 where machine.Key.Equals(machineName, StringComparison.InvariantCultureIgnoreCase) 
                 select _machines[machine.Key]
                ).FirstOrDefault();
        }

        /// <summary>
        /// Loads the types i can return.
        /// </summary>
        private void LoadTypesICanReturn()
        {
            var typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in 
                typesInThisAssembly.Where(type => type.GetInterface(typeof(IMachine).ToString()) != null))
            {
                _machines.Add(type.Name, type);
            }
        }
    }
}
