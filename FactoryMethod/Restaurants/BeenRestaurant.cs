using FactoryMethod.Hamburgers;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Restaurants;

internal class BeenRestaurant : Restaurant
{
    protected override IHamburger CreateHamburger()
    {
        return new BeenHamburger();
    }
}