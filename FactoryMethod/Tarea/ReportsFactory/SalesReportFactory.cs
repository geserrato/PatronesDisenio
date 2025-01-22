using FactoryMethod.Tarea.Abstracts;
using FactoryMethod.Tarea.Interfaces;
using FactoryMethod.Tarea.Reports;

namespace FactoryMethod.Tarea.ReportsFactory;

internal class SalesReportFactory : ReportFactory
{
    protected override IReport CreateReport()
    {
        return new SalesReport();
    }
}