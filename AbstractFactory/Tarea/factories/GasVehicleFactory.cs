using AbstractFactory.Tarea.classes;
using AbstractFactory.Tarea.interfaces;

namespace AbstractFactory.Tarea.factories;

public class GasVehicleFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new GasCar();
    }

    public IEngine CreateEngine()
    {
        return new GasEngine();
    }
}