namespace Interpreter.Context
{
	//This is a class that contains information (Input and Output) that is going to be used by the Interpreter.
	public class Context
	{
		//The Expression Property is going to hold the Output
		public string Expression { get; set; }

		//The Date Property is going to hold the Input
		public DateTime Date { get; set; }

		//While Creating the Context Object, we need to send the Input data
		public Context(DateTime date)
		{
			//Initializing the Input Date Property through the Constructor input parameter value
			Date = date;
		}
	}
}
