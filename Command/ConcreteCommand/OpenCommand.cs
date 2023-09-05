using Command.Command;
using Command.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.ConcreteCommand
{
	// It defines a binding between a Receiver Object i.e. Document and an Action i.e. Open
	public class OpenCommand : ICommand
	{
		//Reference of Receiver Object
		private Document document;

		//Initializing the Receiver Object using the Constructor
		public OpenCommand(Document doc)
		{
			document = doc;
		}

		//Execute Method will internally call the Receiver Object Open Method
		public void Execute()
		{
			document.Open();
		}
	}
}
