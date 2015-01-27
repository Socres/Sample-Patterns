namespace SamplePatterns.State
{
    using System;
    using SamplePatterns.State.Vehicle;

    class Program
    {
        static void Main()
        {
            var car = new Car();
            WriteExceptionToConsole(() => car.StartDriving(), () => "Started driving => Gear " + car.Gear);
            WriteExceptionToConsole(() => car.ShiftUp(), () => "Shifted up => Gear " + car.Gear);
            WriteExceptionToConsole(() => car.StartDriving(), () => "Started driving => Gear " + car.Gear);
            WriteExceptionToConsole(() => car.ShiftUp(), () => "Shifted up => Gear " + car.Gear);
            WriteExceptionToConsole(() => car.ShiftUp(), () => "Shifted up => Gear " + car.Gear);
            WriteExceptionToConsole(() => car.ShiftDown(), () => "Shifted down => Gear " + car.Gear);
            WriteExceptionToConsole(() => car.ShiftUp(), () => "Shifted up => Gear " + car.Gear);
            WriteExceptionToConsole(() => car.ShiftUp(), () => "Shifted up => Gear " + car.Gear);
            Console.ReadLine();
        }

        private static void WriteExceptionToConsole(Action action, Func<string> actionExecuted)
        {
            try
            {
                action();
                Console.WriteLine(actionExecuted());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }
    }
}
