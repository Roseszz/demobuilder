using System.Collections.Generic;
using builderpattern.ComputerParts;

namespace builderpattern {
class Computer {
        private string cpu;
        private string graphiccard;
        private string harddrive;
        private string mainbroad;
        private string ram;

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

        public Computer(string cpu, string graphiccard, string harddrive, string mainbroad, string ram, string color)
        {
            this.cpu = cpu;
            this.graphiccard = graphiccard;
            this.harddrive = harddrive;
            this.mainbroad = mainbroad;
            this.ram = ram;
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

        public void ShowInfor() 
        {
          System.Console.WriteLine("CPU: " + cpu);
          System.Console.WriteLine("GraphicCard: " + graphiccard);
          System.Console.WriteLine("HardDrive: " + harddrive);
          System.Console.WriteLine("MainBroad: " + mainbroad );
          System.Console.WriteLine("RAM: " + ram );
          System.Console.WriteLine("Device Color: " + Color);

        }
  }
}