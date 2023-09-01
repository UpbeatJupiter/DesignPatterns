using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
	public class Book : LibraryItem
	{
		private string author;
		private string title;	

		public Book(string author, string title, int numCopies)
		{
			this.author = author;
			this.title = title;
			NumCopies = numCopies;
		}

		public override void Display()
		{
			Console.WriteLine("\nBook ----- ");
			Console.WriteLine(" Author: {0}", author);
			Console.WriteLine(" Title: {0}", title);
			Console.WriteLine(" # Copies: {0}", NumCopies);
		}
	}
}
