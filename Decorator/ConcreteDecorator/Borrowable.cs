using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Decorator.ConcreteDecorator
{
	public class Borrowable : Decorator.Decorator
	{
		protected readonly List<string> borrowers = new List<string>();

		public Borrowable(LibraryItem libraryItem)
			: base(libraryItem) { }

		public void BorrowItem(string name)
		{
			borrowers.Add(name);
			libraryItem.NumCopies--;
		}

		public void ReturnItem(string name)
		{
			borrowers.Remove(name);
			libraryItem.NumCopies++;
		}

		public override void Display()
		{
			base.Display();

			foreach (string borrower in borrowers)
			{
				Console.WriteLine(" borrower: " + borrower);
			}
		}
	}
}
