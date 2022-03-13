using System.Collections.Generic;
using builderpattern.ComputerParts;

namespace builderpattern {
class Computer {  
    public Cpu Cpu {get;set;}
    public Graphiccard Graphiccard{get;set;}
    public Harddrive Harddrive {get;set;}
    public Mainbroad Mainbroad {get;set;}
    public Ram Ram {get;set;}
    public string Color {get;set;}

    public Computer( Cpu cpu, Graphiccard graphiccard, Harddrive harddrive, Mainbroad mainbroad, Ram ram, string color){
        Cpu = cpu;
        Graphiccard = graphiccard;
        Harddrive = harddrive;
        Mainbroad = mainbroad;
        Ram = ram;
        Color = color;
    }


    public override string ToString()
    {
      var InputParts = "";
      InputParts += $"Type of CPU:            {Cpu.Name}\n";
      InputParts += $"Type of GraphicCard:    {Graphiccard.Name}\n";     
      InputParts += $"Type of HardDrive:      {Harddrive.Name}\n";
      InputParts += $"Type of MainBroad:      {Mainbroad.Name}\n";
      InputParts += $"Amount of RAM:          {Ram.Name}\n";
      InputParts += $"Color:                  {Color}\n";
      return InputParts;
    }
  }
}