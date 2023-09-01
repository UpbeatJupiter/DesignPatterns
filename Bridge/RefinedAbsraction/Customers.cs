using Bridge.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.RefinedAbsraction
{
	public class Customers : CustomersBase
	{
		public override void ShowAll()
		{
			//Add separator lines

			Console.WriteLine();
			Console.WriteLine("-------------------------");

			base.ShowAll();

			Console.WriteLine("-------------------------");
		}
		

	}
}
