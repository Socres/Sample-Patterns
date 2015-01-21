namespace SamplePatterns.Factory.Household.Machines
{
    public class Microwave: IMachine
    {
        public string Name
        {
            get { return "Microwave"; }
        }

        /// <summary>
        /// Turns the microwave on.
        /// </summary>
        /// <returns></returns>
        public string TurnOn()
        {
            return "Microwave turned on.";
        }

        /// <summary>
        /// Turns the microwave off.
        /// </summary>
        public string TurnOff()
        {
            return "Microwave turned off.";
        }
    }
}
