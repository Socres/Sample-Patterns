namespace SamplePatterns.State.Vehicle.States
{
    using System;

    public class ThirdGearState : IGearState
    {
        public bool CanStartDriving(Car car)
        {
            return false;
        }

        public bool CanShiftUp(Car car)
        {
            return false;
        }

        public void ShiftUp(Car car)
        {
            throw new NotImplementedException("Can not shift up, max gear reached.");
        }

        public bool CanShiftDown(Car car)
        {
            return true;
        }

        public void ShiftDown(Car car)
        {
            car.ChangeGear(new SecondGearState());
        }
    }
}
