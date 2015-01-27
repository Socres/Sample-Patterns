namespace SamplePatterns.ChainOfResponsibility.Purchases.Interfaces
{
    public interface IPurchaseHandler
    {
        /// <summary>
        /// Approves the specified purchase.
        /// </summary>
        /// <param name="purchase">The purchase.</param>
        /// <returns></returns>
        ApprovalResponse Approve(IPurchase purchase);

        /// <summary>
        /// Registers the next purchase handler.
        /// </summary>
        /// <param name="next">The next.</param>
        IPurchaseHandler RegisterNext(IPurchaseHandler next);
    }
}
