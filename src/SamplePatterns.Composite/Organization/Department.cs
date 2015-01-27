namespace SamplePatterns.Composite.Organization
{
    using System.Collections.Generic;
    using System.Linq;

    public class Department : IOrganizationUnit
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the members.
        /// </summary>
        public IList<IOrganizationUnit> Members { get; set; }

        /// <summary>
        /// Gets or sets the profit share.
        /// </summary>
        public double ProfitShare
        {
            get
            {
                return Members.Sum(member => member.ProfitShare);
            }
            set
            {
                var eachSplit = value / Members.Count;
                var leftOver = value % Members.Count;
                foreach (var member in Members)
                {
                    member.ProfitShare += eachSplit + leftOver;
                    leftOver = 0;
                }
            }            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Department" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Department(string name)
        {
            Name = name;
            Members = new List<IOrganizationUnit>();
        }

        /// <summary>
        /// Shows the statistics for this <see cref="Department" />.
        /// </summary>
        public void Stats()
        {
            foreach (var member in Members)
            {
                member.Stats();
            }
        }
    }
}
