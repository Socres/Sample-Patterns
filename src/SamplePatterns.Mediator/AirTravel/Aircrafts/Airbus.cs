namespace SamplePatterns.Mediator.AirTravel.Aircrafts
{
    public class Airbus : Aircraft
    {
        public Airbus(string callSign, IAirTrafficControl atc)
            : base(callSign, atc)
        {
        }

        public override int Ceiling
        {
            get { return 40000; }
        }
    }
}
