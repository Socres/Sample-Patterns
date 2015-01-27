namespace SamplePatterns.State.Vehicle
{
    public interface IGearState
    {
        /// <summary>
        /// Determines whether <see cref="Car"/> can start driving.
        /// </summary>
        /// <returns></returns>
        bool CanStartDriving(Car car);

        /// <summary>
        /// Determines whether <see cref="Car"/> can shift up.
        /// </summary>
        /// <returns></returns>
        bool CanShiftUp(Car car);

        /// <summary>
        /// Shifts up <see cref="Car"/> .
        /// </summary>
        void ShiftUp(Car car);

        /// <summary>
        /// Determines whether <see cref="Car"/> can shift down.
        /// </summary>
        /// <returns></returns>
        bool CanShiftDown(Car car);

        /// <summary>
        /// Shifts down <see cref="Car"/> .
        /// </summary>
        void ShiftDown(Car car);
    }
}
