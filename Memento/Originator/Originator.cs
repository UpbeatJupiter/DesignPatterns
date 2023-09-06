using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Originator
{
	//This is going to be a class that creates a memento object containing a snapshot of the Originator's current state. 
	//It also restores the Originator to a previously stored state.
	public class Originator
	{

		//This Property is used to store the current state of the Originator
		public LEDTV LedTV;

		//It will Create a snapshot of the current state of the Originator i.e. Current LedTV 
		//and return that Memento which we can store in the Caretaker i.e. in the Store Room
		public Memento.Memento CreateMemento()
		{
			return new Memento.Memento(LedTV);
		}

		//This Method is going to change the Internal State of the Originator to one of its Previous State
		public void SetMemento(Memento.Memento memento)
		{
			LedTV = memento.LedTV;
		}

		//This Method is going to return the Details of the Current Internal State of the Originator
		public string GetDetails()
		{
			//To Fetch the Details, internally it is calling the GetDetails method on LedTV Object
			return "Originator [LEDTV=" + LedTV.GetDetails() + "]";
		}
	}
}
