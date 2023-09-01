using Builder.Builder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.ConcreteBuilder
{
	public class IglooHouseBuilder : IHouseBuilder
	{
		private House house;

		public IglooHouseBuilder()
		{
			this.house = new House();
		}

		public void buildBasement()
		{
			house.setBasement("Ice Bars");
		}

		public void buildStructure()
		{
			house.setStructure("Ice Blocks");
		}

		public void buildInterior()
		{
			house.setInterior("Ice Carvings");
		}

		public void bulidRoof()
		{
			house.setRoof("Ice Dome");
		}

		public House getHouse()
		{
			return this.house;
		}
	}
}
