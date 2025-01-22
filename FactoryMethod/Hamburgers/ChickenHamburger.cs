using FactoryMethod.Interfaces;

namespace FactoryMethod.Hamburgers;

internal class ChickenHamburger : IHamburger
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Chicken Hamburger");
    }
}
