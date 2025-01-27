using AbstractFactory.interfaces;

namespace AbstractFactory.classes;

public class WaterDrink :IDrink
{
    public void Pour()
    {
        Console.WriteLine("Pouring Water");
    }
}