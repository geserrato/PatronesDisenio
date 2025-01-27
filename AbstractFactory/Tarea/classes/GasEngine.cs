using AbstractFactory.Tarea.interfaces;

namespace AbstractFactory.Tarea.classes;

public class GasEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Motor de gasolina encendido");
    }
}