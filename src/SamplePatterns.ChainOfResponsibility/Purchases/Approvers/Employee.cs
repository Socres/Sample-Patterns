namespace SamplePatterns.ChainOfResponsibility.Purchases.Approvers
{
    /// <summary>
    /// An employee.
    /// </summary>
    public class Employee : PurchaseApprover
    {
        public Employee(string name) 
            : base(name, 0)
        {
        }
    }
}
