using Interpreter.AbstractExpression;

namespace Interpreter.TerminalExpression
{
	//This is going to be a Concrete class that implements the Expression Interface.
	//The following Concrete MonthExpression Class evaluates the Month grammar
	//That is Replacing MM with the Month from the Input Date Property
	public class MonthExpression : IExpression
	{
		public void Evaluate(Interpreter.Context.Context context)
		{
			string expression = context.Expression;
			context.Expression = expression.Replace("MM", context.Date.Month.ToString());
		}
	}
}
