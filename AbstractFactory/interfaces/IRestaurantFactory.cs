namespace AbstractFactory.interfaces;

public interface IRestaurantFactory
{
    internal IHamburger CreateHamburger();
    internal IDrink CreateDrink();
}