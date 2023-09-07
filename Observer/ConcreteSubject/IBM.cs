using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.ConcreteSubject
{
	/// <summary>
	/// The 'ConcreteSubject' class
	/// </summary>
	public class IBM : Stock
	{
		// Constructor
		public IBM(string symbol, double price) : base(symbol, price)
		{
		}
	}
}
