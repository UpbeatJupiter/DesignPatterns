using AbstractFactory.Product;

namespace AbstractFactory.AbstractFactory
{
	public abstract class Company
	{
		public abstract IGpu createGPU();
		public abstract IMonitor createMonitor();
	}
}
