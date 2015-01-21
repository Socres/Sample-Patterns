namespace SamplePatterns.Factory.Household.Machines
{
    public class Car: IMachine
    {
        public string Name
        {
            get { return "Car"; }
        }

        /// <summary>
        /// Turns the car on.
        /// </summary>
        /// <returns></returns>
        public string TurnOn()
        {
            return "Car turned on.";
        }

        /// <summary>
        /// Turns the car off.
        /// </summary>
        public string TurnOff()
        {
            return "Car turned off.";
        }
    }
}
