using builderpattern.ComputerParts;
namespace builderpattern{
    class ComputerBuilder : IComputerBuilder {
    public Cpu Cpu {get;set;}
    public Graphiccard Graphiccard{get;set;}
    public Harddrive Harddrive {get;set;}
    public Mainbroad Mainbroad {get;set;}
    public Ram Ram {get;set;}
    public string Color {get;set;}

    public ComputerBuilder AddCPU(Cpu cpu)
    {
      Cpu = cpu;
      return this;
    }

    public ComputerBuilder AddGraphicCard(Graphiccard graphiccard)
    {
      Graphiccard = graphiccard;
      return this;
    }

    public ComputerBuilder AddHardDrive( Harddrive  harddrive)
    {
      Harddrive = harddrive;
      return this;
    }

    public ComputerBuilder AddMainBroad( Mainbroad  mainbroad)
    {
      Mainbroad = mainbroad;
      return this;
    }

    public ComputerBuilder AddRAM( Ram  ram)
    {
      Ram = ram;
      return this;
    }

    public ComputerBuilder DeviceColor(string color)
    {
      Color = color;
      return this;
    }
    
    public Computer Build()
    {
      return new Computer(Cpu, Graphiccard, Harddrive, Mainbroad, Ram, Color);
    }
    }
}