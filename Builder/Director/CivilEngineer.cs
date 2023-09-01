using Builder.Builder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Director
{
	public class CivilEngineer
	{
		private IHouseBuilder houseBuilder;

		public void setHouseBuilder(IHouseBuilder builder)
		{
			houseBuilder = builder;
		}

		public House getHouse()
		{
			return this.houseBuilder.getHouse();
		}

		public void constructHouse()
		{
			houseBuilder.buildBasement();
			houseBuilder.buildStructure();
			houseBuilder.bulidRoof();
			houseBuilder.buildInterior();
		}
}
	}
