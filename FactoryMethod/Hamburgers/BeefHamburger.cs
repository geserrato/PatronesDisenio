using FactoryMethod.Interfaces;

namespace FactoryMethod.Hamburgers;

internal class BeefHamburger : IHamburger
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Beef Hamburger");
    }
}
