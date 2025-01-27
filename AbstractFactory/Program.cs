// See https://aka.ms/new-console-template for more information

/*
 * ! Abstract Factory Pattern
 * Es un patrón de diseño creacional que nos permite producir familias de objetos relacionados
 * sin especificar sus clases concretas.
 *
 * En lugar de crear objetos individuales directamente, creamos fabricas que producen un conjunto
 * de objetos relacionados.
 *
 * * Es util cuando necesitas crear objetos que son parte de una familia y quieres asegurarte que
 * estos objetos son complementen entre si.
 *
 * https://refactoring.guru/design-patterns/abstract-factory
 *
 * El próposito de Abstract Factory es crear familias de objetos relacionados
 * ( en este caso, Hamburguesas y bebidas) sin especificar la clase concretas
 * de cada uno de los objetos en el código principal.
 */

using AbstractFactory.classes;
using AbstractFactory.interfaces;
using AbstractFactory.Tarea;
using AbstractFactory.Tarea.factories;

/* Main(factory: new FastFoodRestaurantFactory());
Main(factory: new HealthyFoodRestaurantFactory());

void Main(IRestaurantFactory factory)
{
    IHamburger hamburger = factory.CreateHamburger();
    IDrink drink = factory.CreateDrink();
    hamburger.Prepare();
    drink.Pour();
}*/

new MainHomework().Main(new ElectricVehicleFactory());
new MainHomework().Main(new GasVehicleFactory());