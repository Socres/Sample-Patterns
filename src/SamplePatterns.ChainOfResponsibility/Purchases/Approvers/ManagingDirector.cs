namespace SamplePatterns.ChainOfResponsibility.Purchases.Approvers
{
    /// <summary>
    /// A managing director
    /// </summary>
    public class ManagingDirector : PurchaseApprover
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagingDirector" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public ManagingDirector(string name) 
            : base(name, 1000)
        {
        }
    }
}
