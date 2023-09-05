using Interpreter.AbstractExpression;
using Interpreter.Context;
using Interpreter.TerminalExpression;

namespace InterpreterDesignPattern
{
	//This is the class that builds the abstract syntax tree for a set of instructions in the given grammar.
	//This tree builds with the help of instances of NonTerminalExpression and TerminalExpression classes.
	class Program
	{
		static void Main(string[] args)
		{
			//The following is going to be our Expression Tree
			List<IExpression> objExpressions = new List<IExpression>();

			//Creating the context object by passing the current date-time value
			Context context = new Context(DateTime.Now);

			//We want to Interpret the current date time as a specific format
			//Ask the user to select the format
			Console.WriteLine("Please Select the Expression  : MM DD YYYY or YYYY MM DD or DD MM YYYY ");

			context.Expression = Console.ReadLine();

			//Split Expression which the user selects to an array so that we can apply different Expression rules
			string[] strArray = context.Expression.Split(' ');

			//Looping through Each Element of the Expression and adding the Appropriate Expression with the Expression Tree
			foreach (var item in strArray)
			{
				if (item == "DD")
				{
					objExpressions.Add(new DayExpression());
				}
				else if (item == "MM")
				{
					objExpressions.Add(new MonthExpression());
				}
				else if (item == "YYYY")
				{
					objExpressions.Add(new YearExpression());
				}
			}

			//Adding the SeparatorExpression
			objExpressions.Add(new SeparatorExpression());

			foreach (var obj in objExpressions)
			{
				//Finally Evaluate Each Expression which is added in the Expression Tree
				obj.Evaluate(context);
			}

			//Print the Expression as Output
			Console.WriteLine(context.Expression);

			Console.Read();
		}
	}
}