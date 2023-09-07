using Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ConcreteStrategy
{
	public class QuickSort : SortStrategy
	{
		public override void Sort(List<string> list)
		{
			list.Sort();  // Default is Quicksort

			Console.WriteLine("QuickSorted list ");
		}
	}
}
