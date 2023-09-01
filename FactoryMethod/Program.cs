using FactoryMethod.ConcreteCreator;
using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
namespace FactoryMethod
{
	public class Program
	{
		static void Main(string[] args)
		{
			Restaurant beefResto = new BeefBurgerRestaurant();
			Console.WriteLine($"Order from Beef Burger Restaurant");
			beefResto.orderBurger();

			Console.WriteLine("==========================================");

			Restaurant veggieResto = new VeggieBurgerRestaurant();
			Console.WriteLine($"Order from Veggie Burger Restaurant");
			veggieResto.orderBurger();
		}
	}
}