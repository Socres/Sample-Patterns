namespace SamplePatterns.Mediator.AirTravel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Tower : IAirTrafficControl
    {
        private readonly IList<Aircraft> _aircraftUnderGuidance;

        public Tower()
        {
            _aircraftUnderGuidance = new List<Aircraft>();
        }

        public void RegisterAircraftUnderGuidance(Aircraft aircraft)
        {
            if (!_aircraftUnderGuidance.Contains(aircraft))
            {
                _aircraftUnderGuidance.Add(aircraft);
            }
        }

        public void ReceiveAircraftLocation(Aircraft aircraft)
        {
            Console.WriteLine("Aircraft Location => {0} '{1}' altitude {2}",
                aircraft.GetType().Name,
                aircraft.CallSign,
                aircraft.Altitude);

            foreach (var currentAircraftUnderGuidance in _aircraftUnderGuidance.
                            Where(x => !x.Equals(aircraft)))
            {
                if (Math.Abs(currentAircraftUnderGuidance.Altitude - aircraft.Altitude) < 1000)
                {
                    Console.WriteLine("Order climb => {0} '{1}'",
                        aircraft.GetType().Name,
                        aircraft.CallSign);

                    aircraft.Climb(500);

                    Console.WriteLine("Order descent => {0} '{1}'",
                        currentAircraftUnderGuidance.GetType().Name,
                        currentAircraftUnderGuidance.CallSign);

                    currentAircraftUnderGuidance.Descent(250);
                }
            }
        }
    }
}
