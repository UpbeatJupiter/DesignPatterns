using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitor;

namespace Visitor.Element
{
	public abstract class Element
	{
		public abstract void Accept(IVisitor visitor);
	}
}
