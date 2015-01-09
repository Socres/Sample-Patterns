namespace SamplePatterns.Mediator.AirTravel.Aircrafts
{
    using SamplePatterns.Mediator.AirTravel;

    public class Boeing : Aircraft
    {
        public Boeing(string callSign, IAirTrafficControl atc)
            : base(callSign, atc)
        {
        }

        public override int Ceiling
        {
            get { return 33000; }
        }
    }
}
