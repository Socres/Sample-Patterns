namespace SamplePatterns.State.Vehicle.States
{
    using System;

    public class IdleState : IGearState
    {
        public bool CanStartDriving(Car car)
        {
            return false;
        }

        public bool CanShiftUp(Car car)
        {
            return true;
        }

        public void ShiftUp(Car car)
        {
            car.ChangeGear(new FirstGearState());
        }

        public bool CanShiftDown(Car car)
        {
            return false;
        }

        public void ShiftDown(Car car)
        {
            throw new NotImplementedException("Can not shift down");
        }
    }
}
