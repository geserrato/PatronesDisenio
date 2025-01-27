using AbstractFactory.Tarea.factories;
using AbstractFactory.Tarea.interfaces;

namespace AbstractFactory.Tarea;

/*
 * !Instrucciones:
    1.Completen las Clases de Productos:
    •	ElectricCar debe implementar Vehicle y mostrar el mensaje "Ensamblando un auto eléctrico".
    •	GasCar debe implementar Vehicle y mostrar el mensaje "Ensamblando un auto de combustión".
    •	ElectricEngine debe implementar Engine y mostrar el mensaje "Arrancando motor eléctrico".
    •	GasEngine debe implementar Engine y mostrar el mensaje "Arrancando motor de combustión".

    2.	Completen las Clases de Fábricas:
    •	ElectricVehicleFactory debe crear un ElectricCar y un ElectricEngine.
    •	GasVehicleFactory debe crear un GasCar y un GasEngine.

    3. Prueben el Código:
      •	Ejecuten el código para asegurarse de que cada fábrica produce el tipo correcto de vehículo y motor.
 */

internal class MainHomework
{
   internal void Main(IVehicleFactory factory)
    {
        IVehicle vehicle = factory.CreateVehicle();
        IEngine engine = factory.CreateEngine();
        vehicle.Assemble();
        engine.Start();
    }
}