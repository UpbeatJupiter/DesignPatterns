using ChainOfResponsibility.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handler
{
	public abstract class Approver
	{
		protected Approver successor;

		public void SetSuccessor(Approver successor)
		{
			this.successor = successor;
		}

		public abstract void ProcessRequest(Purchase purchase);
	}
}
