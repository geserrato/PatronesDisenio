using FactoryMethod.Interfaces;

namespace FactoryMethod.Hamburgers;

public class BeenHamburger : IHamburger
{
    public void Prepare()
    {
        Console.WriteLine("Preparing been hamburger");
    }
}