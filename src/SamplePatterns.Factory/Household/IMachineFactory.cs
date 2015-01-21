namespace SamplePatterns.Factory.Household
{
    public interface IMachineFactory
    {
        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="description">The description.</param>
        /// <returns>An instance of the IMachine</returns>
        IMachine CreateInstance(string description);
    }
}