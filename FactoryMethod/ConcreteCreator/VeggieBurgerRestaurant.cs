using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
	public class VeggieBurgerRestaurant : Restaurant
	{
		public override IBurger createBurger()
		{
			return new VeggieBurger();
		}
	}
}
