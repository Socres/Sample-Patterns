namespace SamplePatterns.Factory.Household.Machines
{
    public class Robot: IMachine
    {
        public string Name
        {
            get { return "Robot"; }
        }

        /// <summary>
        /// Turns the robot on.
        /// </summary>
        /// <returns></returns>
        public string TurnOn()
        {
            return "Robot turned on.";
        }

        /// <summary>
        /// Turns the robot off.
        /// </summary>
        public string TurnOff()
        {
            return "Robot turned off.";
        }
    }
}
