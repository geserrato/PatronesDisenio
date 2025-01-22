using FactoryMethod.Tarea.Interfaces;

namespace FactoryMethod.Tarea.Reports;

public class InventoryReport : IReport
{
    public void Generate()
    {
        Console.WriteLine("Generating Inventory Report");
    }
}