using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Visitor.Visitor
{
	public interface IVisitor
	{
		void Visit(Element.Element element);
	}
}
