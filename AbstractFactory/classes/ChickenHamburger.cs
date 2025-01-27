using AbstractFactory.interfaces;

namespace AbstractFactory.classes;

public class ChickenHamburger : IHamburger
{
    public void Prepare()
    {
        Console.WriteLine("Preparando hamburgersa de pollo");
    }
}