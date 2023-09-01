using FactoryMethod.Product;


namespace FactoryMethod.ConcreteProduct
{
	public class BeefBurger : IBurger
	{
		public void prepare()
		{
			Console.WriteLine("Beef Burger hazırlanıyor...");
		}
	}
}
