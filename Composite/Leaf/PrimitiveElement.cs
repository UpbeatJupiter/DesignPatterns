using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Leaf
{
	public class PrimitiveElement : DrawingElement
	{
		public PrimitiveElement(string name) : base(name) { }

		public override void Add(DrawingElement d)
		{
			Console.WriteLine("Cannot add to a PrimitiveElement");
		}

		public override void Remove(DrawingElement d)
		{
			Console.WriteLine("Cannot remove from a PrimitiveElement");
		}

		public override void Display(int index)
		{
			Console.WriteLine(new string('-', index) + " " + name);
		}

	}
}
