﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Visitor.ConcreteElement;
using Visitor.Visitor;

namespace Visitor.ConcreteVisitor
{
	public class IncomeVisitor : IVisitor
	{
		public void Visit(Element.Element element)
		{
			Employee employee = element as Employee;

			// Provide 10% pay raise
			employee.Income *= 1.10;

			Console.WriteLine("{0} {1}'s new income: {2:C}",
				employee.GetType().Name, employee.Name,
				employee.Income);
		}
	}

}
