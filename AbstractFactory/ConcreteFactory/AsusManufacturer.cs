using AbstractFactory.AbstractFactory;
using AbstractFactory.ConcreteProduct;
using AbstractFactory.Product;

namespace AbstractFactory.ConcreteFactory
{
	public class AsusManufacturer : Company
	{
		public override IGpu createGPU()
		{
			Console.WriteLine("Asus GPU created.");
			return new AsusGpu();
		}

		public override IMonitor createMonitor()
		{
			Console.WriteLine("Asus Monitor created.");
			return new AsusMonitor();
		}
	}
}
