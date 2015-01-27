namespace SamplePatterns.Composite.Organization
{
    public interface IOrganizationUnit
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets or sets the profit share.
        /// </summary>
        double ProfitShare { get; set; }

        /// <summary>
        /// Shows the statistics for this <see cref="IOrganizationUnit"/>.
        /// </summary>
        void Stats();
    }
}
