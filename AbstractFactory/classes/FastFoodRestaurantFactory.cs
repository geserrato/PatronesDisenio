using AbstractFactory.interfaces;

namespace AbstractFactory.classes;

public class FastFoodRestaurantFactory : IRestaurantFactory
{
    public IHamburger CreateHamburger()
    {
        return new BeefHamburger();
    }

    public IDrink CreateDrink()
    {
        return new SodaDrink();
    }
}