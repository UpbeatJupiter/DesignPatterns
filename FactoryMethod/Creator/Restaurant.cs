using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creator
{
	public abstract class Restaurant
	{
		public IBurger orderBurger()
		{
			IBurger burger = createBurger();
			burger.prepare();
			return burger;

		}
		public abstract IBurger createBurger();
	}
}
