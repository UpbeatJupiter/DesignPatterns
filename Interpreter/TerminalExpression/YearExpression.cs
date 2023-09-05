using Interpreter.AbstractExpression;

namespace Interpreter.TerminalExpression
{
	//This is going to be a Concrete class that implements the Expression Interface.
	//The following Concrete YearExpression Class evaluates the Year grammar
	//That is Replacing YYYY with the Year from the Input Date Property
	public class YearExpression : IExpression
	{
		public void Evaluate(Interpreter.Context.Context context)
		{
			string expression = context.Expression;
			context.Expression = expression.Replace("YYYY", context.Date.Year.ToString());
		}
	}
}
