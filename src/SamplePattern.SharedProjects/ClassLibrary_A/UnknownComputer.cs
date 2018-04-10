namespace ClassLibrary_A
{
  public class UnknownComputer : IComputer
  {
    public string Make => "Unknown computer";
    public string Mhz => string.Empty;
    public bool PowerOn()
    {
      return false;
    }

  }
}
