namespace PatronBuilder;

internal class Computer
{
    public string Cpu { get; set; } = "CPU - NOT DEFINED";
    public string Ram { get; set; } = "RAM - NOT DEFINED";
    public string Storage { get; set; } = "STORAGE - NOT DEFINED";
    public string? Gpu { get; set; }

    public void DisplayConfiguration()
    {
        Console.WriteLine(
            $"Computer's Configuration -> CPU:{Cpu}, RAM: {Ram}, STORAGE: {Storage}, GPU: {Gpu ?? "NOT DEFINED"}");
    }
}