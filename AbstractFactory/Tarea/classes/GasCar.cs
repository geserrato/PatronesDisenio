using AbstractFactory.Tarea.interfaces;

namespace AbstractFactory.Tarea.classes;

public class GasCar : IVehicle
{
    public void Assemble()
    {
        Console.WriteLine("Ensamblado de auto a gasolina");
    }
}