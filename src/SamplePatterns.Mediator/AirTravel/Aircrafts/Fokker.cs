namespace SamplePatterns.Mediator.AirTravel.Aircrafts
{
    public class Fokker : Aircraft
    {
        public Fokker(string callSign, IAirTrafficControl atc)
            : base(callSign, atc)
        {
        }

        public override int Ceiling
        {
            get { return 40000; }
        }
    }
}
