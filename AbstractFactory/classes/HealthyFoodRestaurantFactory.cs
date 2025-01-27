using AbstractFactory.interfaces;

namespace AbstractFactory.classes;

public class HealthyFoodRestaurantFactory : IRestaurantFactory
{
    public IHamburger CreateHamburger()
    {
        return new ChickenHamburger();
    }

    public IDrink CreateDrink()
    {
        return new WaterDrink();
    }
}