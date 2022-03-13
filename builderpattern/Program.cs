using System;
using builderpattern.ComputerParts;
namespace builderpattern
{
  class Program 
  {
    static void Main(string[] args)
    {
       ProductManager p = new ProductManager();
            p.Run();
    }
  }
}
