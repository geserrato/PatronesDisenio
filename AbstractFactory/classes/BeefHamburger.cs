using AbstractFactory.interfaces;

namespace AbstractFactory.classes;

public class BeefHamburger :IHamburger
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Beef Hamburger");
    }
}