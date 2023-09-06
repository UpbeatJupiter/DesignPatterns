using Mediator.Colleague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator
{
	//Mediator Interface
	//This is going to be an Interface that defines operations 
	//which can be called by colleague objects for communication.
	public interface IFacebookGroupMediator
	{
		//This Method is used to send the Message who are registered with the Facebook Group
		void SendMessage(string msg, User user);

		//This method is used to register a user with the Facebook Group
		void RegisterUser(User user);
	}
}
