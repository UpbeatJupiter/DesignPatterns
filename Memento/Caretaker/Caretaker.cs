using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Caretaker
{
	//This is going to be a class that is used to hold a Memento object for later use.
	//This acts as a store only; it never Checks or Modifies the contents of the Memento object.
	public class Caretaker
	{
		//This variable is going to hold the List of Mementos that are used by the Originator.
		private List<Memento.Memento> LedTvList = new List<Memento.Memento>();
		//This Method will add the memento i.e. the internal state of the Originator into the Caretaker i.e. Store Room 
		public void AddMemento(Memento.Memento m)
		{
			LedTvList.Add(m);
			Console.WriteLine("LED TV's snapshots Maintained by CareTaker :" + m.GetDetails());
		}
		//This Method is used to return one of the Previous Originator Internal States which saved in the Caretaker
		public Memento.Memento GetMemento(int index)
		{
			return LedTvList[index];
		}
	}
}
