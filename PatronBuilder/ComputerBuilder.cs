namespace PatronBuilder;

internal class ComputerBuilder
{
    private readonly Computer _computer = new();

    public ComputerBuilder SetCpu(string cpu)
    {
        _computer.Cpu = cpu;
        return this;
    }

    public ComputerBuilder SetRam(string ram)
    {
        _computer.Ram = ram;
        return this;
    }

    public ComputerBuilder SetStorage(string storage)
    {
        _computer.Storage = storage;
        return this;
    }

    public ComputerBuilder SetGpu(string gpu)
    {
        _computer.Gpu = gpu;
        return this;
    }

    public Computer Build()
    {
        return this._computer;
    }
}