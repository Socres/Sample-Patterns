namespace SamplePatterns.Strategy
{
    using System;
    using SamplePatterns.Strategy.CostCalculation;
    using SamplePatterns.Strategy.CostCalculation.ShippingStrategies;

    class Program
    {
        private static void Main(string[] args)
        {
            var numberOfProductsString = "Unknown";
            while (!string.IsNullOrEmpty(numberOfProductsString))
            {
                Console.WriteLine("Enter number of products:");
                numberOfProductsString = Console.ReadLine();
                int numberOfProducts;
                if (int.TryParse(numberOfProductsString, out numberOfProducts))
                {
                    Console.WriteLine("Enter delivery service :");
                    var deliveryServiceName = Console.ReadLine();
                    var shippingStrategy = CreateShippingStrategy(deliveryServiceName);

                    var order = new Order {NumberOfProducts = numberOfProducts};
                    var costService = new CostService();
                    var cost = costService.CalculateCost(order, shippingStrategy);
                    Console.WriteLine("Total cost using {0}: {1}", shippingStrategy.Name, cost);
                    Console.WriteLine("**********");
                }
            }
        }

        private static IShippingStrategy CreateShippingStrategy(string deliveryServiceName)
        {
            // This can be massivly improved using some other pattern. Can you guess which one? :)
            if (deliveryServiceName.Equals("fedex", StringComparison.InvariantCultureIgnoreCase))
            {
                return new FedexShippingStrategy();
            }
            if (deliveryServiceName.Equals("tnt", StringComparison.InvariantCultureIgnoreCase))
            {
                return new TntShippingStrategy();
            }
            return new UpsShippingStrategy();
        }
    }
}
