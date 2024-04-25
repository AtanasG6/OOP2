using PolymorphismDemo;

public class Program
{
	public static void Main()
	{
		Vehicle airplane = new Airplane();
		Vehicle truck = new Truck();
		Vehicle airfighter = new AirFighter();
		IVehicle ship = new Ship();
		//PrintVehicleModel(airplane);
		//PrintVehicleModel(truck);
		//PrintVehicleModel(new Ship());

		List<Vehicle> vehicles = new List<Vehicle>() { airplane, truck };
		List<IVehicle> vehicles2 = new List<IVehicle>() { airplane, truck, new Ship() };

		//Searches the method:
		PrintDrive(airplane); //Airplane => Vehicle => Object
		PrintDrive(truck); //Truck => Vehicle => Object
		PrintDrive(new AirFighter()); //AirFighter => Airplane => Vehicle => Object
		PrintDrive(new CatOnAJet());
        Console.WriteLine(ship.Drive());

        //thanks to polymorphism foreach, LINQ, etc. work with queue, stack, LIst<T>.... because of the IEnumerable<T> interface


        Console.WriteLine();

        //But if the method is not virtual:
        PrintStop(airplane);
		PrintStop(truck);

		//Casting does not remove data!
		Airplane airplaneSecond = new Airplane()
		{
			MaxPeople = 100
		};

		Vehicle castVehicle = airplaneSecond;
		Airplane castAirplane = (Airplane)castVehicle;

		Console.WriteLine(castAirplane.MaxPeople);

		Print(airfighter);


		Console.ReadLine();
	}


	//Don't do this
//	public static void PrintAirplaneModel(Airplane airplane)
//	{
//		Console.WriteLine(airplane.Model);
//	}

//	public static void PrintTruckModel(Truck truck)
//	{
//		Console.WriteLine(truck.Model);
//	}

	//Do this that works abstractly

	public static void PrintVehicleModel(Vehicle vehicle)
	{
		if (vehicle.Model is not null)
		{
			Console.WriteLine(vehicle.Model);
		}
		else
		{
            Console.WriteLine("null");
        }
		
	}

	public static void PrintDrive(Vehicle vehicle)
	{
        Console.WriteLine(vehicle.Drive());
    }

	public static void PrintStop(Vehicle vehicle)
	{
		Console.WriteLine(vehicle.Stop());
	}

	public static void Print(object obj)
	{
		if (obj is Vehicle vehicle)
		{
            Console.WriteLine(vehicle.Drive());
        }
		else if (obj is string text)
		{
            Console.WriteLine(text.Length);
        }
		else if (obj is AirFighter fighter)
		{
            Console.WriteLine(fighter.ShootARacket());
		}
	}
}