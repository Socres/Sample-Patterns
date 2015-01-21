namespace SamplePatterns.Factory.Household
{
    public interface IMachine
    {
        string Name { get; }

        /// <summary>
        /// Turns the machine on.
        /// </summary>
        string TurnOn();

        /// <summary>
        /// Turns the machine off.
        /// </summary>
        string TurnOff();
    }
}
