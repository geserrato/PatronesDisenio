using AbstractFactory.interfaces;

namespace AbstractFactory.classes;

public class SodaDrink : IDrink
{
    public void Pour()
    {
        Console.WriteLine("Pouring Soda Drink");
    }
}