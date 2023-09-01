using AbstractFactory.AbstractFactory;
using AbstractFactory.ConcreteProduct;
using AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteFactory
{
	public class MsiManufacturer : Company
	{
		public override IGpu createGPU()
		{
			Console.WriteLine("Msi GPU created.");
			return new MsiGpu();
		}

		public override IMonitor createMonitor()
		{
			Console.WriteLine("Msi Monitor created.");
			return new MsiMonitor();
		}
	}
}
