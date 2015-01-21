namespace SamplePatterns.Strategy.CostCalculation.ShippingStrategies
{
    public class FedexShippingStrategy : IShippingStrategy
    {
        public string Name
        {
            get { return "Fedex"; }
        }

        /// <summary>
        /// Calculates the shipping costs for the specified order.
        /// </summary>
        /// <param name="order">The order.</param>
        public double Calculate(Order order)
        {
            return 10d;
        }
    }
}
