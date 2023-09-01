using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
	public class CompositeElement : DrawingElement
	{
		List<DrawingElement> elements = new List<DrawingElement>();

		public CompositeElement(string name) : base(name) { }

		public override void Add(DrawingElement d)
		{
			elements.Add(d);
		}
		public override void Remove(DrawingElement d)
		{
			elements.Remove(d);	
		}
		public override void Display(int index)
		{
			Console.WriteLine(new string('-', index) + "+" + name);

			//Display each child element on this node

			foreach (DrawingElement d in elements)
			{
				d.Display(index + 2);
			}
		}
	}
}
