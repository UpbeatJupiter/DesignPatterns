using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
	// It declares a method for executing a command
	public interface ICommand
	{
		void Execute();
	}
}
