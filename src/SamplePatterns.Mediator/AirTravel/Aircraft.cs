namespace SamplePatterns.Mediator.AirTravel
{
    using System;

    public abstract class Aircraft
    {
        private readonly IAirTrafficControl _atc;
        private int _currentAltitude;

        protected Aircraft(string callSign, IAirTrafficControl atc)
        {
            _atc = atc;
            CallSign = callSign;
            _atc.RegisterAircraftUnderGuidance(this);
        }

        public abstract int Ceiling { get; }

        public string CallSign { get; private set; }

        public int Altitude
        {
            get { return _currentAltitude; }
            private set
            {
                if (_currentAltitude != value)
                {
                    _currentAltitude = value;
                    _atc.ReceiveAircraftLocation(this);
                }
            }
        }

        public void Climb(int heightToClimb)
        {
            Altitude = Math.Min(Altitude + heightToClimb, Ceiling);
        }

        public void Descent(int heightToDescent)
        {
            Altitude = Math.Max(Altitude - heightToDescent, 0);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType()) return false;

            var incoming = (Aircraft)obj;
            return CallSign.Equals(incoming.CallSign);
        }

        public override int GetHashCode()
        {
            return CallSign.GetHashCode();
        }
    }
}
