using P01.Vehicles.Core;
using P01.Vehicles.Core.Contracts;

public class StartUp
{
	public static void Main()
	{
		IEngine engine = new Engine();
		engine.Run();
	}
}