namespace SamplePatterns.Strategy.CostCalculation.ShippingStrategies
{
    public class UpsShippingStrategy : IShippingStrategy
    {
        public string Name
        {
            get { return "Ups"; }
        }

        /// <summary>
        /// Calculates the shipping costs for the specified order.
        /// </summary>
        /// <param name="order">The order.</param>
        public double Calculate(Order order)
        {
            if (order.NumberOfProducts < 3)
            {
                return 2.50d;
            }

            return 2.00d * order.NumberOfProducts;
        }
    }
}
