using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.ConcreteElement;

namespace Visitor
{
	public class Director : Employee
	{
		// Constructor
		public Director() : base("Elly", 35000.0, 16)
		{
		}
	}
}
