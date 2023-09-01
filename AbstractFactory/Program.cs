using AbstractFactory.AbstractFactory;
using AbstractFactory.ConcreteFactory;
using AbstractFactory.Product;
using System.Collections.Generic;

namespace AbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			Company msiFactory = new MsiManufacturer();
			IGpu msiGpu = msiFactory.createGPU();
			IMonitor msiMonitor = msiFactory.createMonitor();

			Console.WriteLine("\n");
			msiGpu.assemble();
			msiMonitor.assemble();

			Console.WriteLine("--------------------------");

			Company asusFactory = new AsusManufacturer();
			IGpu asusGpu = asusFactory.createGPU();
			IMonitor asusMonitor = asusFactory.createMonitor();

			Console.WriteLine("\n");
			asusGpu.assemble();
			asusMonitor.assemble();


		}
	}
}