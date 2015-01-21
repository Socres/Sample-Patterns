namespace SamplePatterns.Strategy.CostCalculation.ShippingStrategies
{
    public class TntShippingStrategy : IShippingStrategy
    {
        public string Name
        {
            get { return "Tnt"; }
        }

        /// <summary>
        /// Calculates the shipping costs for the specified order.
        /// </summary>
        /// <param name="order">The order.</param>
        public double Calculate(Order order)
        {
            return 2.20d * order.NumberOfProducts;
        }
    }
}
