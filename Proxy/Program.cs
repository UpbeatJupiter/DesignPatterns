using Proxy.ProxyObject;

namespace Proxy
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Create math proxy
			MathProxy proxy = new MathProxy();

			// Do the math
			Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
			Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
			Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
			Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
			// Wait for user
			Console.ReadKey();
		}
	}

}