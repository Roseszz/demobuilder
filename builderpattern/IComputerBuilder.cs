using builderpattern.ComputerParts;
namespace builderpattern{
    interface IComputerBuilder{
        ComputerBuilder AddCPU( Cpu  cpu);
        ComputerBuilder AddGraphicCard( Graphiccard  graphiccard);
        ComputerBuilder AddHardDrive( Harddrive  harddrive);
        ComputerBuilder AddMainBroad( Mainbroad  mainbroad);
        ComputerBuilder AddRAM( Ram  ram);
        ComputerBuilder DeviceColor( string color);
        Computer Build();
    }
}