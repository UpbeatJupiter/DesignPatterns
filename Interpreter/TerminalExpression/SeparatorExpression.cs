using Interpreter.AbstractExpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.TerminalExpression
{
	//This is going to be a Concrete class that implements the Expression Interface.
	//The following Concrete SeparatorExpression Class evaluates the separate grammar
	//That is Replacing space with the - in the Expression string which is going to be our output
	public class SeparatorExpression : IExpression
	{
		public void Evaluate(Interpreter.Context.Context context)
		{
			string expression = context.Expression;
			context.Expression = expression.Replace(" ", "-");
		}
	}
}
