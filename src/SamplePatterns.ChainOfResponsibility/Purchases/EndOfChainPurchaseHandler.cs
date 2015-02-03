namespace SamplePatterns.ChainOfResponsibility.Purchases
{
    using System;
    using SamplePatterns.ChainOfResponsibility.Purchases.Interfaces;

    public class EndOfChainPurchaseHandler : IPurchaseHandler, IPurchaseApprover
    {
        private static readonly Lazy<EndOfChainPurchaseHandler> LazyInstance = 
            new Lazy<EndOfChainPurchaseHandler>(
                () => new EndOfChainPurchaseHandler(),
                true);

        private EndOfChainPurchaseHandler() { }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static EndOfChainPurchaseHandler Instance
        {
            get { return LazyInstance.Value; }
        }

        public string Name
        {
            get { return "End of Chain"; }
        }

        /// <summary>
        /// Approves the specified purchase.
        /// </summary>
        /// <param name="purchase">The purchase.</param>
        /// <returns></returns>
        public ApprovalResponse Approve(Purchase purchase)
        {
            return new ApprovalResponse(this, ApprovalStatus.Denied);
        }

        /// <summary>
        /// Registers the next purchase handler.
        /// </summary>
        /// <param name="next">The next.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public IPurchaseHandler RegisterNext(IPurchaseHandler next)
        {
            throw new InvalidOperationException("End of chain handler must be the end of the chain!");
        }
    }
}
