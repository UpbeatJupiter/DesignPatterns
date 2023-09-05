using Command.Command;
using Command.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.ConcreteCommand
{
	//It defines a binding between a Receiver Object i.e. Document and an Action i.e. Close
	public class CloseCommand : ICommand
	{
		//Reference of Receiver Object
		private Document document;

		//Initializing the Receiver Object using the Constructor
		public CloseCommand(Document doc)
		{
			document = doc;
		}

		//Execute Method will internally call the Receiver Object Close Method
		public void Execute()
		{
			document.Close();
		}
	}
}
