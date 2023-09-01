using AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteProduct
{
	public class MsiGpu : IGpu
	{
		public void assemble()
		{
			Console.WriteLine("Assembling Msi GPU");
		}
	}
}
