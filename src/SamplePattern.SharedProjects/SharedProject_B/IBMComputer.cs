using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_A
{
  public class IBMComputer : IComputer
  {
    public string Make => "XT 286";
    public string Mhz => "4.77MHz";
    public bool PowerOn()
    {
      return true;
    }
  }
}
