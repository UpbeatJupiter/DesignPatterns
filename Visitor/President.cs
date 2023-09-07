using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.ConcreteElement;

namespace Visitor
{
	public class President : Employee
	{
		// Constructor
		public President() : base("Eric", 45000.0, 21)
		{
		}
	}
}
