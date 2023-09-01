using Builder.Builder;
using Builder.ConcreteBuilder;
using Builder.Director;
using Builder.Product;

public class Program
{
	 static void Main(string[] args)
	{
		IHouseBuilder iglooBuilder = new IglooHouseBuilder();
		CivilEngineer engineer = new CivilEngineer();

		engineer.setHouseBuilder(iglooBuilder);
		engineer.constructHouse();

		House house = engineer.getHouse();

		Console.WriteLine("Builder constructed: " + house);

	}
}
