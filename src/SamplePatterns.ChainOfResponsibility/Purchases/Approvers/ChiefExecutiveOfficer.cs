namespace SamplePatterns.ChainOfResponsibility.Purchases.Approvers
{
    /// <summary>
    /// The CEO
    /// </summary>
    public class ChiefExecutiveOfficer: PurchaseApprover
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChiefExecutiveOfficer"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public ChiefExecutiveOfficer(string name) 
            : base(name, 100000)
        {
        }
    }
}
