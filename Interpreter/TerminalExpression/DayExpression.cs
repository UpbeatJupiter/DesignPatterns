using Interpreter.AbstractExpression;

namespace Interpreter.TerminalExpression
{
	//This is going to be a Concrete class that implements the Expression Interface.
	//The following Concrete DayExpression Class evaluates the Day grammar
	//That is Replacing DD with the Day from the Input Date Property
	public class DayExpression : IExpression
	{
		public void Evaluate(Interpreter.Context.Context context)
		{
			string expression = context.Expression;
			context.Expression = expression.Replace("DD", context.Date.Day.ToString());
		}
	}
}
