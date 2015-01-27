namespace SamplePatterns.Composite.Organization
{
    using System;

    public class Employee : IOrganizationUnit
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the profit share.
        /// </summary>
        public double ProfitShare { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Employee(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Shows the statistics for this <see cref="Employee" />.
        /// </summary>
        public void Stats()
        {
            Console.WriteLine("{0} has {1} profit.", Name, string.Format("{0:0.00}", Math.Round(ProfitShare, 2)));
        }
    }
}
