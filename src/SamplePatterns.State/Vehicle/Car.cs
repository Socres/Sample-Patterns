namespace SamplePatterns.State.Vehicle
{
    using System;
    using SamplePatterns.State.Vehicle.States;

    /// <summary>
    /// A Car
    /// </summary>
    public class Car
    {
        private IGearState _gearState;

        public string Gear
        {
            get { return _gearState.GetType().Name; }
        }

        public Car()
        {
            _gearState = new IdleState();
        }

        public void ChangeGear(IGearState state)
        {
            _gearState = state;
        }

        /// <summary>
        /// Determines whether this instance can start driving.
        /// </summary>
        /// <returns></returns>
        public bool CanStartDriving()
        {
            return _gearState.CanStartDriving(this);
        }

        /// <summary>
        /// Start driving.
        /// </summary>
        public void StartDriving()
        {
            if (CanStartDriving())
            {
                //
            }
            else
            {
                throw new InvalidOperationException("Can not start driving in this gear.");
            }
        }

        /// <summary>
        /// Determines whether the instance can shift up.
        /// </summary>
        /// <returns></returns>
        public bool CanShiftUp()
        {
            return _gearState.CanShiftUp(this);
        }

        /// <summary>
        /// Shifts up the instance.
        /// </summary>
        public void ShiftUp()
        {
            if (CanShiftUp())
            {
                _gearState.ShiftUp(this);
            }
            else
            {
                throw new InvalidOperationException("Can not shift up in this gear.");
            }
        }

        /// <summary>
        /// Determines whether the instance can shift down.
        /// </summary>
        /// <returns></returns>
        public bool CanShiftDown()
        {
            return _gearState.CanShiftDown(this);
        }

        /// <summary>
        /// Shifts down the instance.
        /// </summary>
        public void ShiftDown()
        {
            if (CanShiftDown())
            {
                _gearState.ShiftDown(this);
            }
            else
            {
                throw new InvalidOperationException("Can not shift down in this gear.");
            }
        }
    }
}
