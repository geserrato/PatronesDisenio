namespace AbstractFactory.Tarea.interfaces;

public interface IVehicleFactory
{
    public IVehicle CreateVehicle();
    public IEngine CreateEngine();
}