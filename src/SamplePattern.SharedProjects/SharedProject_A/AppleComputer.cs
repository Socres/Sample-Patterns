using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_A
{
  public class AppleComputer : IComputer
  {
    public string Make => "Rotten Apples";

    public string Mhz => "1337MHz";
    
    public bool PowerOn()
    {
      return true;
    }

  }
}
