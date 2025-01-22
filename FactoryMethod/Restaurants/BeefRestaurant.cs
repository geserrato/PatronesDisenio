using FactoryMethod.Hamburgers;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Restaurants;

internal class BeefRestaurant : Restaurant
{
    protected override IHamburger CreateHamburger()
    {
        return new BeefHamburger();
    }
}
