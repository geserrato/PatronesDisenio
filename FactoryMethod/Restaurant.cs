using FactoryMethod.Interfaces;

namespace FactoryMethod;

internal abstract class Restaurant
{
    protected abstract IHamburger CreateHamburger();

    public void OrderHamburger()
    {
        IHamburger hamburger = CreateHamburger();
        hamburger.Prepare();
    }
}
