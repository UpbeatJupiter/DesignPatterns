using Mediator.Colleague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ConcreteColleague
{
	//Concrete Colleague
	//These are the classes that communicate with each other via the mediator.
	public class ConcreteUser : User
	{
		//Parameterized Constructor is required to set the base class Name Property
		public ConcreteUser(string Name) : base(Name)
		{
		}

		//Overriding the Receive Method
		//This method is going to use by the Mediator to send the message to each member of the group
		public override void Receive(string message)
		{
			Console.WriteLine(this.Name + ": Received Message:" + message);
		}

		//This method is used to send the message to the Mediator by a user
		public override void Send(string message)
		{
			Console.WriteLine(this.Name + ": Sending Message=" + message + "\n");
			Mediator.SendMessage(message, this);
		}
	}
}
