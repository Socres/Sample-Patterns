namespace SamplePatterns.ChainOfResponsibility.Purchases.Interfaces
{
    public interface IPurchaseApprover
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Approves the specified purchase.
        /// </summary>
        /// <param name="purchase">The purchase.</param>
        /// <returns></returns>
        ApprovalResponse Approve(Purchase purchase);
    }
}
