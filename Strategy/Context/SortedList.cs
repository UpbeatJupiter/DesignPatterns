using Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Context
{
	public class SortedList
	{
		private List<string> list = new List<string>();
		private SortStrategy sortstrategy;

		public void SetSortStrategy(SortStrategy sortstrategy)
		{
			this.sortstrategy = sortstrategy;
		}

		public void Add(string name)
		{
			list.Add(name);
		}

		public void Sort()
		{
			sortstrategy.Sort(list);

			// Iterate over list and display results
			foreach (string name in list)
			{
				Console.WriteLine(" " + name);
			}

			Console.WriteLine();
		}
	}
}
