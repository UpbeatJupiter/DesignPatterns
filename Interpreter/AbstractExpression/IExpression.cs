namespace Interpreter.AbstractExpression
{
	//This is going to be an interface that defines the Interpret operation, which must be implemented by each subclass.
	public interface IExpression
	{
		void Evaluate(Interpreter.Context.Context context);
	}
}
