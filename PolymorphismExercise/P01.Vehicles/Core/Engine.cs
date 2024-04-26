using P01.Vehicles.Core.Contracts;
using P01.Vehicles.Factories;
using P01.Vehicles.Models;

namespace P01.Vehicles.Core
{
	public class Engine : IEngine
	{
		private VehicleFactory VehicleFactory;

		public Engine()
		{
			this.VehicleFactory = new VehicleFactory();
		}
		public void Run()
		{
			Vehicle car = ProduceVehicle();
			Vehicle truck = ProduceVehicle();

			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				string[] cmdArgs = Console.ReadLine()
					.Split(' ',
					StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

				try
				{
					ProcessCommand(car, truck, cmdArgs);
				}
				catch (InvalidOperationException ioe)
				{

                    Console.WriteLine(ioe.Message);
                }
				
			}
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

		private static void ProcessCommand(Vehicle car, Vehicle truck, string[] cmdArgs)
		{
			string cmdType = cmdArgs[0];
			string vehicleType = cmdArgs[1];
			double arg = double.Parse(cmdArgs[2]);

			if (cmdType == "Drive")
			{
				if (vehicleType == "Car")
				{
					Console.WriteLine(car.Drive(arg));
				}
				else if (vehicleType == "Truck")
				{
					Console.WriteLine(truck.Drive(arg)); 
				}
			}
			else if (cmdType == "Refuel")
			{
				if (vehicleType == "Car")
				{
					car.Refuel(arg);
				}
				else if (vehicleType == "Truck")
				{
					truck.Refuel(arg);
				}
			}
		}

		private Vehicle ProduceVehicle()
		{
			string[] vehicleArgs = Console.ReadLine()
							.Split(' ',
							StringSplitOptions.RemoveEmptyEntries)
							.ToArray();
			string type = vehicleArgs[0];
			double fuelQty = double.Parse(vehicleArgs[1]);
			double fuelConsumption = double.Parse(vehicleArgs[2]);

			Vehicle vehicle = this.VehicleFactory.ProduceVehicle
				(type, fuelQty, fuelConsumption);
			return vehicle;
		}
	}
}
