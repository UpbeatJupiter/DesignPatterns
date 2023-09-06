using Memento.Caretaker;
using Memento.Originator;
using Memento;

namespace Memento
{
	class Program
	{
		static void Main(string[] args)
		{
			//Creating an Instance of the Originator and setting the current state as a 42-Inch Led TV
			Originator.Originator originator = new Originator.Originator
			{
				LedTV = new LEDTV("42-Inch", "60000", false)
			};

			//Storing the Internal State (Memento i.e. the Current Led TV) of the Originator in the Caretaker i.e. Store Room
			//First, Create an instance of the Caretaker
			Caretaker.Caretaker caretaker = new Caretaker.Caretaker();

			//Second Create a snapshot or memento of the current internal state of the originator
			Memento.Memento memento = originator.CreateMemento();

			//Third, store the memento or snapshot in the store room i.e. Caretaker
			caretaker.AddMemento(memento);

			//Changing the Originator Current State to 46-Inch
			originator.LedTV = new LEDTV("46-Inch", "80000", true);

			//Again storing the Internal State (Memento) of the Originator in the Caretaker i.e. Store Room
			//Create the memento or snapshot of the current internal state of the originator
			memento = originator.CreateMemento();

			//Store the memento in the Caretaker
			caretaker.AddMemento(memento);

			//Again, Changing the Originator Current State to 50-Inch
			originator.LedTV = new LEDTV("50-Inch", "100000", true);

			//The Current State of the Originator is now 50-Inch Led TV
			Console.WriteLine("\nOrignator Current State : " + originator.GetDetails());

			//Restoring the Originator to one of its previous states
			//We have added two Memento to the Caretaker
			//Index-0 means the First memento i.e. 42 Inch LED TV
			//Index-1 means the Second memento i.e. 46 Inch LED TV
			Console.WriteLine("\nOriginator Restoring to 42-Inch LED TV");

			originator.SetMemento(caretaker.GetMemento(0));

			Console.WriteLine("\nOrignator Current State : " + originator.GetDetails());

			Console.ReadKey();
		}
	}
}