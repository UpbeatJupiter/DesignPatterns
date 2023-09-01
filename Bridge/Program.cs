using Bridge.ConcreteImplementor;
using Bridge.RefinedAbsraction;

namespace Bridge
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//Create RefinedAbstraction

			var customers = new Customers();

			//Set ConcreteImplementor

			customers.Data = new CustomersData("Chicago");
						

			//Exercise the Bridge

			customers.Show();
			customers.Next();
			customers.Show();
			customers.Next();
			customers.Show();
			customers.Add("Henry Velasquez");

			customers.ShowAll();

			//Wait for user

			Console.ReadKey();
		}
	}
}