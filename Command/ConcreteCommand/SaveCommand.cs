using Command.Command;
using Command.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.ConcreteCommand
{
	//It defines a binding between a Receiver Object i.e. Document and an Action i.e. Save
	public class SaveCommand : ICommand
	{
		//Reference of Receiver Object
		private Document document;

		//Initializing the Receiver Object using the Constructor
		public SaveCommand(Document doc)
		{
			document = doc;
		}

		//Execute Method will internally call the Receiver Object Save Method
		public void Execute()
		{
			document.Save();
		}
	}
}
