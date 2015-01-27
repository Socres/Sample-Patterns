namespace SamplePatterns.ChainOfResponsibility
{
    using System;
    using SamplePatterns.ChainOfResponsibility.Purchases;
    using SamplePatterns.ChainOfResponsibility.Purchases.Approvers;

    class Program
    {
        static void Main()
        {
            var john = new PurchaseHandler(new Employee("John Doe"));
            var jane = new PurchaseHandler(new Manager("Jane Doe"));
            var scott = new PurchaseHandler(new ManagingDirector("Scott G."));
            var bill = new PurchaseHandler(new ChiefExecutiveOfficer("Bill G."));

            john.RegisterNext(jane)
                .RegisterNext(scott)
                .RegisterNext(bill);

            var purchase = new Purchase(213, "Supplies", 125);
            var approvalResponse = john.Approve(purchase);
            Console.WriteLine("The purchase {0} for {1} worth {2} was {3} by {4}.", 
                purchase.Number,
                purchase.Purpose,
                purchase.Amount,
                approvalResponse.Status, 
                approvalResponse.Approver);

            purchase = new Purchase(214, "Hardware", 1500);
            approvalResponse = john.Approve(purchase);
            Console.WriteLine("The purchase {0} for {1} worth {2} was {3} by {4}.",
                purchase.Number,
                purchase.Purpose,
                purchase.Amount,
                approvalResponse.Status,
                approvalResponse.Approver);

            purchase = new Purchase(215, "Aston Martin", 125000);
            approvalResponse = john.Approve(purchase);
            Console.WriteLine("The purchase {0} for {1} worth {2} was {3} by {4}.",
                purchase.Number,
                purchase.Purpose,
                purchase.Amount,
                approvalResponse.Status,
                approvalResponse.Approver);

            Console.ReadLine();
        }
    }
}
