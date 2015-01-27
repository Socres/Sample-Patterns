namespace SamplePatterns.ChainOfResponsibility.Purchases
{
    using SamplePatterns.ChainOfResponsibility.Purchases.Interfaces;

    public class PurchaseHandler : IPurchaseHandler
    {
        private readonly IPurchaseApprover _approver;
        private IPurchaseHandler _next;

        public PurchaseHandler(IPurchaseApprover expenseApprover)
        {
            _approver = expenseApprover;
            _next = EndOfChainPurchaseHandler.Instance;
        }

        /// <summary>
        /// Approves the specified purchase.
        /// </summary>
        /// <param name="purchase">The purchase.</param>
        /// <returns></returns>
        public ApprovalResponse Approve(IPurchase purchase)
        {
            var response = _approver.Approve(purchase);

            if (response.Status == ApprovalStatus.BeyondApprovalLimit)
            {
                return _next.Approve(purchase);
            }

            return response;
        }

        /// <summary>
        /// Registers the next purchase handler.
        /// </summary>
        /// <param name="next">The next.</param>
        /// <returns></returns>
        public IPurchaseHandler RegisterNext(IPurchaseHandler next)
        {
            _next = next;
            return _next;
        }
    }
}
