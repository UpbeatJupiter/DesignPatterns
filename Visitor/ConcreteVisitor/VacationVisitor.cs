using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Visitor.ConcreteElement;
using Visitor.Visitor;

namespace Visitor.ConcreteVisitor
{
	public class VacationVisitor : IVisitor
	{
		public void Visit(Element.Element element)
		{
			Employee employee = element as Employee;

			// Provide 3 extra vacation days
			employee.VacationDays += 3;

			Console.WriteLine("{0} {1}'s new vacation days: {2}",
				employee.GetType().Name, employee.Name,
				employee.VacationDays);
		}
	}
}
