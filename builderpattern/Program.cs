using System;
using builderpattern.ComputerParts;
namespace builderpattern
{
  class Program
  {
    static void Main(string[] args)
    {
      var computerByBuilder = new ComputerBuilder()
      .AddCPU(new Cpu("Intel core i3"))
      .AddGraphicCard(new Graphiccard("RTX 3090"))
      .AddHardDrive(new Harddrive("SSD"))
      .AddMainBroad(new Mainbroad("Asus"))
      .AddRAM(new Ram("12 GB"))
      .DeviceColor("red")
      .Build();   
      Console.WriteLine(computerByBuilder.ToString());
    }
  }
}
