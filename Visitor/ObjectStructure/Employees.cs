using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.ConcreteElement;
using Visitor.Visitor;

namespace Visitor.ObjectStructure
{
	public class Employees
	{
		private List<Employee> employees = new List<Employee>();

		public void Attach(Employee employee)
		{
			employees.Add(employee);
		}

		public void Detach(Employee employee)
		{
			employees.Remove(employee);
		}

		public void Accept(IVisitor visitor)
		{
			foreach (Employee employee in employees)
			{
				employee.Accept(visitor);
			}
			Console.WriteLine();
		}
	}

}
