using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.AbstractClass;

namespace TemplateMethod.ConcreteClass
{
	public class Products : DataAccessor
	{
		private List<string> products;

		public override void Connect()
		{
			products = new List<string>();
		}

		public override void Select()
		{
			products.Add("Car");
			products.Add("Bike");
			products.Add("Boat");
			products.Add("Truck");
			products.Add("Moped");
			products.Add("Rollerskate");
			products.Add("Stroller");
		}

		public override void Process(int top)
		{
			Console.WriteLine("Products ---- ");

			for (int i = 0; i < top; i++)
			{
				Console.WriteLine(products[i]);
			}
			Console.WriteLine();
		}

		public override void Disconnect()
		{
			products.Clear();
		}
	}
}
