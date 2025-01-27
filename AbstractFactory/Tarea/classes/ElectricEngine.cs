using AbstractFactory.Tarea.interfaces;

namespace AbstractFactory.Tarea.classes;

public class ElectricEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Motor eléctrico encendido");
    }
}