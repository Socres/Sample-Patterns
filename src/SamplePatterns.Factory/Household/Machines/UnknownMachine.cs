namespace SamplePatterns.Factory.Household.Machines
{
    public class UnknownMachine : IMachine
    {
        public string Name
        {
            get { return "Unknown machine"; }
        }

        /// <summary>
        /// Turns the car on.
        /// </summary>
        /// <returns></returns>
        public string TurnOn()
        {
            return string.Empty;
        }

        /// <summary>
        /// Turns the car off.
        /// </summary>
        public string TurnOff()
        {
            return string.Empty;
        }
    }
}
