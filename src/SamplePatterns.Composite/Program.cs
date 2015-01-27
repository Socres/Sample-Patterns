namespace SamplePatterns.Composite
{
    using System;
    using SamplePatterns.Composite.Organization;

    class Program
    {
        static void Main()
        {
            var organization = BuildOrganization();
            Console.WriteLine("Enter profit:");
            var profitString = Console.ReadLine();
            Console.WriteLine("**********");
            double profit;
            if (double.TryParse(profitString, out profit))
            {
                organization.ProfitShare = profit;
                organization.Stats();
            }
            Console.ReadLine();
        }

        private static IOrganizationUnit BuildOrganization()
        {
            var organization = new Department("Dummy Company");

            var marketing = new Department("Marketing");
            organization.Members.Add(marketing);
            marketing.Members.Add(new Employee("Bob"));
            marketing.Members.Add(new Employee("Jane"));
            marketing.Members.Add(new Employee("John"));
            
            var development = new Department("Development");
            organization.Members.Add(development);

            var developers = new Department("Developers");
            development.Members.Add(developers);
            developers.Members.Add(new Employee("Scott"));
            developers.Members.Add(new Employee("David"));
            developers.Members.Add(new Employee("Angelina"));
            developers.Members.Add(new Employee("Tom"));

            var testers = new Department("Testers");
            development.Members.Add(testers);
            testers.Members.Add(new Employee("Iris"));
            testers.Members.Add(new Employee("Dave"));

            return organization;
        }
    }
}
