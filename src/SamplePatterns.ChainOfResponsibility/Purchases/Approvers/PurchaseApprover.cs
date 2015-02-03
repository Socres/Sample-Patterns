namespace SamplePatterns.ChainOfResponsibility.Purchases.Approvers
{
    using System;
    using SamplePatterns.ChainOfResponsibility.Purchases.Interfaces;

    public abstract class PurchaseApprover : IPurchaseApprover
    {
        private readonly Double _approvalLimit;

        public string Name { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseApprover"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="approvalLimit">The approval limit.</param>
        protected PurchaseApprover(string name, Double approvalLimit)
        {
            Name = name;
            _approvalLimit = approvalLimit;
        }

        /// <summary>
        /// Approves the specified purchase.
        /// </summary>
        /// <param name="purchase">The purchase.</param>
        /// <returns></returns>
        public ApprovalResponse Approve(Purchase purchase)
        {
            return 
                new ApprovalResponse(
                    this, 
                    purchase.Amount > _approvalLimit
                        ? ApprovalStatus.BeyondApprovalLimit
                        : ApprovalStatus.Approved);
        }
    }
}
