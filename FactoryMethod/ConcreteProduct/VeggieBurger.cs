using FactoryMethod.Product;


namespace FactoryMethod.ConcreteProduct
{
	public class VeggieBurger : IBurger
	{
		public void prepare()
		{
			Console.WriteLine("Veggie Burger hazırlanıyor...");
		}
	}
}
