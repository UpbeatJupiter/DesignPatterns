using AbstractFactory.Product;

namespace AbstractFactory.ConcreteProduct
{
	public class AsusMonitor : IMonitor
	{
		public void assemble()
		{
			Console.WriteLine("Assembling ASUS Monitor");
		}
	}
}
