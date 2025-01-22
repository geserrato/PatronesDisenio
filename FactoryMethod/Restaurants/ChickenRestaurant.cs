using FactoryMethod.Hamburgers;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Restaurants;

internal class ChickenRestaurant : Restaurant
{
    protected override IHamburger CreateHamburger()
    {
        return new ChickenHamburger();
    }
}
