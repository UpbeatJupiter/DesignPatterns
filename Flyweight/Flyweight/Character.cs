using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Flyweight
{
	public abstract class Character
	{
		protected char symbol;
		protected int width;
		protected int height;
		protected int ascent;
		protected int descent;
		protected int pointSize;
		public abstract void Display(int pointSize);
	}
}
