using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp_SharedProjects
{
  using ClassLibrary_A;

  class Program
  {
    static void Main(string[] args)
    {
      var computerFactory = new ComputerFactory();

      var apple = computerFactory.Create("AppleComputer");
      var ibm = computerFactory.Create("IBMComputer");

      Console.WriteLine($"{apple.Make} @{apple.Mhz} - PoweredOn: {apple.PowerOn()}");
      Console.WriteLine($"{ibm.Make} @{ibm.Mhz} - PoweredOn: {ibm.PowerOn()}");

      Console.ReadLine();
    }
  }
}
