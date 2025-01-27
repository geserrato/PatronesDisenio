using AbstractFactory.Tarea.interfaces;

namespace AbstractFactory.Tarea.classes;

public class ElectricCar : IVehicle
{
    public void Assemble()
    {
        Console.WriteLine("Ensamblado de auto eléctrico");
    }
}