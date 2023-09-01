using AbstractFactory.Product;

namespace AbstractFactory.ConcreteProduct
{
	public class MsiMonitor : IMonitor
	{
		public void assemble()
		{
			Console.WriteLine("Assembling Msi Monitor");
		}
	}
}
