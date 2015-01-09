namespace SamplePatterns.Mediator.AirTravel
{
    public interface IAirTrafficControl
    {
        void RegisterAircraftUnderGuidance(Aircraft aircraft);
        void ReceiveAircraftLocation(Aircraft aircraft);
    }
}
