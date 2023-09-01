using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adaptee
{
	public class Adaptee
	{
		// The Adaptee contains some useful behavior, but its interface is
		// incompatible with the existing client code. The Adaptee needs some
		// adaptation before the client code can use it.
		public string GetSpecificRequest()
		{
			return "Specific request.";
		}
	}
}
