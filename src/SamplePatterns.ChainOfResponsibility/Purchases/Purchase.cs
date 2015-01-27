namespace SamplePatterns.ChainOfResponsibility.Purchases
{
    using SamplePatterns.ChainOfResponsibility.Purchases.Interfaces;

    public class Purchase: IPurchase
    {
        public double Amount { get; private set; }

        public string Purpose { get; private set; }

        public int Number { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Purchase"/> class.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <param name="purpose">The purpose.</param>
        /// <param name="number">The number.</param>
        public Purchase(int number, string purpose, double amount)
        {
            Amount = amount;
            Purpose = purpose;
            Number = number;
        }
    }
}
