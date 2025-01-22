using FactoryMethod.Tarea.Interfaces;

namespace FactoryMethod.Tarea.Reports;

public class SalesReport : IReport
{
    public void Generate()
    {
        Console.WriteLine("Generating Sales Report");
    }
}