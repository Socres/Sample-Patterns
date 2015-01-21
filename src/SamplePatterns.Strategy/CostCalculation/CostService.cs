namespace SamplePatterns.Strategy.CostCalculation
{
    public class CostService
    {
        /// <summary>
        /// Calculates the cost.
        /// </summary>
        /// <param name="order">The order.</param>
        /// <param name="shippingStrategy">The shipping strategy.</param>
        /// <returns></returns>
        public double CalculateCost(Order order, IShippingStrategy shippingStrategy)
        {
            const double defaultCost = 5d;
            return defaultCost + shippingStrategy.Calculate(order);
        }
    }
}
