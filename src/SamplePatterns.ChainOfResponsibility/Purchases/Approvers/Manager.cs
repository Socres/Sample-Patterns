namespace SamplePatterns.ChainOfResponsibility.Purchases.Approvers
{
    /// <summary>
    /// A manager.
    /// </summary>
    public class Manager : PurchaseApprover
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Manager"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Manager(string name) 
            : base(name, 250)
        {
        }
    }
}
