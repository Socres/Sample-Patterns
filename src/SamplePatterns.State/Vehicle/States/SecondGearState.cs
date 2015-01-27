namespace SamplePatterns.State.Vehicle.States
{
    public class SecondGearState : IGearState
    {
        public bool CanStartDriving(Car car)
        {
            return true;
        }

        public bool CanShiftUp(Car car)
        {
            return true;
        }

        public void ShiftUp(Car car)
        {
            car.ChangeGear(new ThirdGearState());
        }

        public bool CanShiftDown(Car car)
        {
            return true;
        }

        public void ShiftDown(Car car)
        {
            car.ChangeGear(new FirstGearState());
        }
    }
}
