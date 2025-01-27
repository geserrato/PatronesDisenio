using AbstractFactory.Tarea.classes;
using AbstractFactory.Tarea.interfaces;

namespace AbstractFactory.Tarea.factories;

public class ElectricVehicleFactory:IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new ElectricCar();
    }

    public IEngine CreateEngine()
    {
        return new ElectricEngine();
    }
}