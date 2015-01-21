namespace SamplePatterns.Strategy.CostCalculation
{
    public interface IShippingStrategy
    {
        string Name { get; }

        /// <summary>
        /// Calculates the shipping costs for the specified order.
        /// </summary>
        /// <param name="order">The order.</param>
        double Calculate(Order order);
    }
}
