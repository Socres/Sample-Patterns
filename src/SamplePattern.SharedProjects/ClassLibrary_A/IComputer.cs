namespace ClassLibrary_A
{
    public interface IComputer
    {
        string Make { get; }
        string Mhz { get; }

        bool PowerOn();

    }
}
