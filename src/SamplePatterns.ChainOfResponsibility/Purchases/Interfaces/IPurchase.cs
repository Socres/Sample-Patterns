namespace SamplePatterns.ChainOfResponsibility.Purchases.Interfaces
{
    public interface IPurchase
    {
        double Amount { get; }
        string Purpose { get; }
        int Number { get; }
    }
}
