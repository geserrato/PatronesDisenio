using FactoryMethod.Tarea.Interfaces;

namespace FactoryMethod.Tarea.Abstracts;

internal abstract class ReportFactory
{
    protected abstract IReport CreateReport();
    
    public void GenerateReport()
    {
        IReport report = CreateReport();
        report.Generate();
    }
}