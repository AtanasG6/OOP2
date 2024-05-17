using OOPTask2;

public class Program
{
	public static void Main()
	{
		var list1 = new List<Room>() 
		{
			new Kitchen(15, "Blue"),
			new Bathroom(25, "Red")
		};
		var list2 = new List<Room>()
		{
			new Bedroom(40, "Green")
		};

		Building[] buildings = { new Building(15 , 30, "Red"),
								 new House(150, "White", list1, new Person("Gosho"))};



		foreach (var building in buildings)
		{
			Console.WriteLine(building);
		}

	}
}