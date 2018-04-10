namespace ClassLibrary_A
{
    public interface IComputerFactory
    {
        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="description">The description.</param>
        /// <returns>An instance of the IComputer</returns>
        IComputer Create(string description);
    }
}