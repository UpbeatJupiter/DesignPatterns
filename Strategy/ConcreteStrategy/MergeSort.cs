using Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ConcreteStrategy
{
	public class MergeSort : SortStrategy
	{
		public override void Sort(List<string> list)
		{
			//list.MergeSort(); not-implemented
			Console.WriteLine("MergeSorted list ");
		}
	}
}
