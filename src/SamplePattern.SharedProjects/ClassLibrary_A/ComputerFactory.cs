namespace ClassLibrary_A
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    
    public class ComputerFactory : IComputerFactory
    {
        private readonly Dictionary<string, Type> _computers;

        public ComputerFactory()
        {
            this._computers = new Dictionary<string, Type>();

            LoadTypesICanReturn();
        }

        public IComputer Create(string description)
        {
            var type = GetTypeToCreate(description);

            if (type == null)
            {
                return new UnknownComputer();
            }

            return Activator.CreateInstance(type) as IComputer;
        }

        private Type GetTypeToCreate(string computerMake)
        {
            return 
                (from computer in this._computers 
                 where computer.Key.Equals(computerMake, StringComparison.InvariantCultureIgnoreCase) 
                 select this._computers[computer.Key]
                ).FirstOrDefault();
        }

        private void LoadTypesICanReturn()
        {
            var typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in 
                typesInThisAssembly.Where(type => type.GetInterface(typeof(IComputer).ToString()) != null))
            {
                this._computers.Add(type.Name, type);
            }
        }
    }
}
