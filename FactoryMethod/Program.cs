/*
 * ! Factory Method:
 * El patrón Factory Method permite crear objetos sin especificar
 * la clase exacta del objeto que se creará.
 *
 * En lugar de eso, delegamos la creación de objetos a subclases o métodos
 * que encapsulan esta lógica.
 *
 * * Es útil cuando una clase no puede anticipar la clase
 * * de objetos que debe crear.
 *
 * https://refactoring.guru/es/design-patterns/factory-method
 *
 */

using FactoryMethod;
using FactoryMethod.Restaurants;
using FactoryMethod.Tarea.Abstracts;
using FactoryMethod.Tarea.ReportsFactory;

// Lanza una entrada en consola para seleccionar el tipo de hamburguesa
/*Console.WriteLine("Select the type of hamburger");
Console.WriteLine("1. Chicken-burger");
Console.WriteLine("2. Beef-burger");
Console.WriteLine("3. Been-burger");

// Lee la entrada del usuario
var optionSelected = int.Parse(Console.ReadLine());

// Crea una instancia de la clase 
Restaurant restaurant = optionSelected switch
{
    1 => new ChickenRestaurant(),
    2 => new BeefRestaurant(),
    3 => new BeenRestaurant(),
    _ => throw new ArgumentException("Invalid option")
};

restaurant.OrderHamburger();*/

// Lanza una entrada en consola para seleccionar el tipo de reporte
Console.WriteLine("Select the type of report");
Console.WriteLine("1. Sales Report");
Console.WriteLine("2. Inventory Report");

// Lee la entrada del usuario
var optionSelected = int.Parse(Console.ReadLine());

// Crea una instancia de la clase
ReportFactory reportFactory = optionSelected switch
{
    1 => new SalesReportFactory(),
    2 => new InventoryReportFactory(),
    _ => throw new ArgumentException("Invalid option")
};

reportFactory.GenerateReport();