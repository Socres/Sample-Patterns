namespace SamplePatterns.Mediator
{
    using System;
    using SamplePatterns.Mediator.AirTravel;
    using SamplePatterns.Mediator.AirTravel.Aircrafts;

    class Program
    {
        static void Main()
        {
            var tower = new Tower();

            var flight1 = new Airbus("AC159", tower);
            var flight2 = new Boeing("WS203", tower);
            var flight3 = new Fokker("AC602", tower);

            Console.WriteLine("Enter start height:");
            var heightString = Console.ReadLine();
            Console.WriteLine("**********");
            int height;
            if (int.TryParse(heightString, out height))
            {
                flight1.Climb(height);
            }
            Console.WriteLine("**********");
            Console.WriteLine("{0} altitude: {1}", flight1.CallSign, flight1.Altitude);
            Console.WriteLine("{0} altitude: {1}", flight2.CallSign, flight2.Altitude);
            Console.WriteLine("{0} altitude: {1}", flight3.CallSign, flight3.Altitude);
            Console.ReadLine();
        }
    }
}
