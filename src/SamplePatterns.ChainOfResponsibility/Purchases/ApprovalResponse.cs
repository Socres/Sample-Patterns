namespace SamplePatterns.ChainOfResponsibility.Purchases
{
    using SamplePatterns.ChainOfResponsibility.Purchases.Interfaces;

    public class ApprovalResponse
    {
        public string Approver { get; private set; }

        public ApprovalStatus Status { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalResponse"/> class.
        /// </summary>
        /// <param name="approver">The approver.</param>
        /// <param name="status">The status.</param>
        public ApprovalResponse(IPurchaseApprover approver, ApprovalStatus status)
        {
            Approver = approver.Name;
            Status = status;
        }
    }
}
