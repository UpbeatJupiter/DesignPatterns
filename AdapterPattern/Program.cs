using AdapterPattern.Target;
using AdapterPattern.Adaptee;
namespace AdapterPattern
{
	public class Program
	{
		static void Main(string[] args)
		{
			Adaptee.Adaptee adaptee = new Adaptee.Adaptee();
			ITarget target = new Adapter.Adapter(adaptee);

			Console.WriteLine("Adaptee interface is incompatible with the client.");
			Console.WriteLine("But with adapter client can call it's method.");

			Console.WriteLine(target.GetRequest());
		}
	}
}